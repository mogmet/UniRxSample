using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

public class TopController : MonoBehaviour
{
    private TopViewModel viewModel = new TopViewModel();
    // Start is called before the first frame update
    void Start()
    {
        viewModel.river.Subscribe(value => Debug.Log("throw... " + value)).AddTo(this);
        viewModel.river
            .Where(value => value == "peach")
            .Select(value => value + "can")
            .Subscribe(value => Debug.Log(value))
            .AddTo(this);
        viewModel.throwValue("unko");
        viewModel.throwValue("peach");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
