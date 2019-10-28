using UnityEngine;
using System.Collections;
using UnityEngine.UI;
namespace HujanKue
{


    public class UIManager : MonoBehaviour
    {
        public GameManager GM;


        // Use this for initialization
        void Start()
        {
            //--------------------------------------------------------------------------
            // Game Settings Related Code


            //--------------------------------------------------------------------------
            // Music Settings Related Code

        }

        // Update is called once per frame
        void Update()
        {
            ScanForKeyStroke();
        }

        void ScanForKeyStroke()
        {
            if (Input.GetKeyDown("escape")) GM.TogglePauseMenu();
        }

        //-----------------------------------------------------------
        // Game Options Function Definitions

    }
}

