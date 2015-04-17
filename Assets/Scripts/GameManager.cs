using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
		public void Play ()
		{
				Application.LoadLevel (Application.loadedLevel + 1);
		}
}
