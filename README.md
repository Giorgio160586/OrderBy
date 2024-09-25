var list = new List<string>() {
        "Y",
        "A",
        "F",
        "​Z"
    };

list = list.OrderBy(x => x).ToList();
list.ForEach(x => Debug.Print(x));

output:
​Z
A
F
Y
