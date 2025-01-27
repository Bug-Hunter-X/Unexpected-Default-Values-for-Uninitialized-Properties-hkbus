public class ExampleClass{
    public int MyProperty { get; set; }

    public ExampleClass(){
        MyProperty = -1; //Explicit Initialization
    }
    public void MyMethod() {
        Console.WriteLine(MyProperty); 
    }
}