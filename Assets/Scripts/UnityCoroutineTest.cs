using System.Collections;

using UnityEngine;

public class UnityCoroutineTest : MonoBehaviour {

    private IEnumerator Start()
    {
        _LogWithTime("Start enter");
        yield return StartCoroutine(_ProcessA());
        _LogWithTime("Start exit");
    }

    private IEnumerator _ProcessA()
    {
        _LogWithTime("A enter");
        yield return StartCoroutine(_ProcessB());
        _LogWithTime("A exit");
    }

    private IEnumerator _ProcessB()
    {
        _LogWithTime("B enter");
        yield break;
    }

    private void _LogWithTime(string message)
    {
        Debug.LogFormat("{0}: {1}", Time.realtimeSinceStartup, message);
    }
}
