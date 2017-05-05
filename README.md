# ForEachSameIndex

Provide a set of DotNet extension methods for iterating over List<>s of the same length. 

```C#
var t1 = new List<int> { 1, 2, 3 };
var t2 = new List<int> { 1, 2, 3 };
var expected = new List<int> { 2, 4, 6 };
var actual = new List<int>();
t1.ForEachSameIndex(t2, (x1, x2) => actual.Add(x1 + x2));
Assert.Equal(expected, actual);
```
