using UnityEngine;
using System.Collections;

namespace com.QH.QPGame.SH
{

    public class UIExitBox : MonoBehaviour
    {
        //
        static UIExitBox instance = null;
        //
        ConfirmCall _ConfirmCall = null;
        //
        CancelCall _CancelCall = null;
        //
        GameObject o_MsgBox = null;



        void Start()
        {

        }

        void Update()
        {

        }
        void Awake()
        {
            o_MsgBox = GameObject.Find("scene_exit");
            if (instance == null)
            {
                instance = this;
            }

        }

        private void OnDestroy()
        {
            instance = null;
        }


        //
        public void Show(bool bshow)
        {
            if (bshow)
            {
                o_MsgBox.SetActive(bshow);
            }
            else
            {
                o_MsgBox.SetActive(bshow);
            }
        }
        //
        public ConfirmCall ConfirmCallBack
        {
            set { _ConfirmCall = value; }
        }
        //
        public CancelCall CancelCallBack
        {
            set { _CancelCall = value; }
        }
        //
        public static UIExitBox Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameObject("UIExitBox").AddComponent<UIExitBox>();
                }
                return instance;
            }
        }
        //
        void OnOkIvk()
        {

            if (_ConfirmCall != null)
                _ConfirmCall();

            Show(false);

            _ConfirmCall = null;
            _CancelCall = null;
        }
        //
        void OnCancelIvk()
        {

            if (_CancelCall != null)
                _CancelCall();

            Show(false);

            _ConfirmCall = null;
            _CancelCall = null;
        }

    }
}