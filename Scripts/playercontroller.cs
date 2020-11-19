using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
[RequireComponent(typeof(AudioSource))]

public class playercontroller : MonoBehaviour
{
    [SerializeField] private float speed; // une variable modifiable dans l'inspector (pour la vitesse)
    [SerializeField] private float maxSpeed; // une variable modifiable dans l'inspector (pour la vitesse max)
    [SerializeField] private float jumpForce; // une variable modifiable dans l'inspector (pour la hauteur du saut)
    [SerializeField] private LayerMask ground; // une variable pour détecter la Tilemap 
    [SerializeField] private AudioClip[] m_FootstepSounds = default;
    [SerializeField] private AudioClip m_JumpSound = default;
    [SerializeField] private AudioClip m_LandSound = default;

    private Controls controls; // une variable pour les Inputes
    private Vector2 direction; // une variable pour définir les déplacements du Player

    private bool isOnGround = false; // cette variable défini quand le joueur n'est pas sur le sol 

    private Rigidbody myRigidbody; // une variable pour modifier le RB du player
    private Animator myAnimator; // une variable pour modifer les transitions dans l'inspector 
    private SpriteRenderer myRenderer; // une variable pour modifier le sprite qui va s'afficher pendant les animations
    private float myStepCycle;
    private float myNextStep;
    private AudioSource myAudioSource;
    private AudioClip[] footStepsOverride;
    private AudioClip jumpSoundOverride;
    private AudioClip landSoundOverride;
    private bool isInSpecialSurface;

    private void OnEnable() // fonction qui active les Inputs
    {
        controls = new Controls(); // on instancie l'input system cree dans unity
        controls.Enable(); // 'idem' fonction qui active les Inputs
        controls.playercontrol.Move.performed += OnMovePerformed; // on lance la fonction OnMovePerformed
        controls.playercontrol.Move.canceled += OnMoveCanceled; // on lance la fonction OnMoveCanceled
        controls.playercontrol.Jump.performed += JumpOnperformed; // on lance la fonction OnJumpPerformed
        myRigidbody = GetComponent<Rigidbody>(); // récupérer le composant correspondant au <Rigidbody> pour pouvoir agir dessus
        myAnimator = GetComponent<Animator>(); // récupérer le composant correspondant a l'<Animator> pour pouvoir agir dessus
        myRenderer = GetComponent<SpriteRenderer>(); // récupérer le composant correspondant au <SpriteRenderer> pour pouvoir agir dessus
        myAudioSource = GetComponent<AudioSource>();

    }


    private void Start()
    {
        myStepCycle = 0f;
        myNextStep = myStepCycle / 2f;
        myAudioSource = GetComponent<AudioSource>();

    }

    private void Update()
    {
        PlayLandingSound();
    }


    private void PlayLandingSound()
    {
        if (isInSpecialSurface)
        {
            myAudioSource.clip = landSoundOverride;
        }
        else
        {
            myAudioSource.clip = m_LandSound;
        }
        myAudioSource.Play();
        myNextStep = myStepCycle + .5f;
    }


    private void Move_performed(InputAction.CallbackContext obj) // fonction qui active les InputAction
    {
        throw new System.NotImplementedException(); // fonction automatique 
    }

    private void JumpOnperformed(InputAction.CallbackContext obj) // si IsOnGround est vrai, on ajoute une force (JumpForce) vers le haut sur le Player
    {                                                             // puis on repasse à faux pour arrêter d'ajouter la force même si on continue d'enclencher l'input
        if (isOnGround) // condition si le player est sur le sol 
        {
            myRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // fonction pour définir la force du Jump
            isOnGround = false; // fonction pour la détection du sol 
            
        }

    }
    private void OnMovePerformed(InputAction.CallbackContext obj) // la variable direction recupère la position (-1, 0 ou 1) des inputs enclenchés 
    {
        direction = obj.ReadValue<Vector2>(); // fonction pour définir la valeur de la direction 
       // Debug.Log(direction);
    }

    private void OnMoveCanceled(InputAction.CallbackContext obj) // fonction quand l'InputMove n'est pas activer 
    {
        direction = Vector2.zero; // fonction pour stopper le déplacement 
    }

   
    private void FixedUpdate()
    {
        // créer la transition entre l'animation idle et walk 
        // le Player se déplace que sur l'axe x 
        // on change l'orientation du sprite en fonction de sa direction 
        

        var myRigidbody = GetComponent<Rigidbody>();
        direction.y = 0;
        if (myRigidbody.velocity.sqrMagnitude < maxSpeed)
            myRigidbody.AddForce(direction * speed);
        var isRunning = direction.x != 0;
        var isJumping = myRigidbody.velocity.y != 0;
        myAnimator.SetBool("IsJumping", isJumping);
        // if (direction.y < 0)
        myAnimator.SetBool("IsRunning", isRunning);
        Debug.Log(isRunning);
        if (direction.x < 0)
        {
            myRenderer.flipX = true; 

        }
        else if (direction.x > 0)
        {
            myRenderer.flipX = false;
        }
    }

    private void OnCollisionEnter(Collision other) // si le Player collisionne avec un GameObject qui a le tag "Ground" IsOnGround passe en true pour que le Player puisse sauter
    {
       if (other.gameObject.CompareTag("Ground")) // fonction pour détecter les collisions 
       {
           // Debug.Log("Test");
            isOnGround = true; // fonction pour la détection du sol 
        }

    }
}
