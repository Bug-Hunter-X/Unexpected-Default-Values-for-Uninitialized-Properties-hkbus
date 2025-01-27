public class ExampleClass{
    public int MyProperty { get; set; }

    public void MyMethod() {
        // Accessing a property before it's initialized can lead to unexpected behavior.
        Console.WriteLine(MyProperty); //This will print 0 instead of null or throwing exception 
    }
}