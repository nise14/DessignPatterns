﻿namespace Observer.Core;
public interface IObserver
{
    void Update(ISubject subject);
} 