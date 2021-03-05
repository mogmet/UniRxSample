using System;
using UniRx;

public class TopViewModel
{
    public IObservable<string> river => _river.AsObservable();
    private ISubject<string> _river = new Subject<string>();

    public void throwValue(string value)
    {
        _river.OnNext(value);
    }
}