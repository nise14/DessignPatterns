using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator.Core;

public abstract class IteratorAggregate : IEnumerable
{
    // Returns an Iterator or another IteratorAggregate for the implementing
    // object.
    public abstract IEnumerator GetEnumerator();
}