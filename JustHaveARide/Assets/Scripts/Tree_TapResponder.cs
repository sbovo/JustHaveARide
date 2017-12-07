using HoloToolkit.Unity.InputModule;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree_TapResponder : MonoBehaviour, IInputClickHandler
{
        public void OnInputClicked(InputClickedEventData eventData)
        {
            // Increase the scale of the object just as a response.
            gameObject.transform.localScale += 0.05f * gameObject.transform.localScale;

            eventData.Use(); // Mark the event as used, so it doesn't fall through to other handlers.
        }
}
