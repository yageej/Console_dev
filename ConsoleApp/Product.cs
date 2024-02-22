namespace ConsoleApp;

public class Product
{
    //attributes
    // automatic property creation
    public int productId{get;set;}
    public string productName{get;set;}
    public float productPrice{get; set;}


    // Overloading Constructor sample with parameter or 
    //multiple constructor with same name but diff number 
    // of parameter/arguments
    public Product(int productId, string productName)
    {
        this.productId = productId;
        this.productName = productName;
    }

    public Product(int productId, string productName, float productPrice)
    {
        this.productId = productId;
        this.productName = productName;
        this.productPrice = productPrice;
            Console.WriteLine("Proudct ID: "+productId);
            Console.WriteLine("Proudct Name: "+productName);
            Console.WriteLine("Proudct Price: "+productPrice);

    }

    public Product(){ // no parameter

    }
    // public void printProduct(int n1, string p1, float p2){
        
    //         Console.WriteLine("Proudct ID: "+productId);
    //         Console.WriteLine("Proudct Name: "+productName);
    //         Console.WriteLine("Proudct Price: "+productPrice);
    // }


}
