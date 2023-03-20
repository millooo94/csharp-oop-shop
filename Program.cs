var productNames = new string[] { "Pen", "Pencil", "Eraser" };
var products = new Product[3];

for (int i = 0; i < products.Length; i++)
{
    var productIndex = productNames[i];
    var product = new Product(productIndex);
    product.Description = "This is " + productNames[i] + " number " + (i + 1);
    product.Price = 2.99 + i;
    if (i == 0)
    {
        product.Iva = 26543987632;
    } else
    {
        product.Iva = i * 123456789;
    }
    var untaxedPrice = product.GetUntaxedPrice();
    var taxedPrice = product.GetTaxedPrice();
    var extendedName = product.GetExtendedName();
    var paddedCode = product.GetPaddedCode();
    products[i] = product;
    Console.WriteLine(product.Name);
    Console.WriteLine(product.Description);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Iva);
    Console.WriteLine(untaxedPrice);
    Console.WriteLine(taxedPrice);
    Console.WriteLine(extendedName);
    Console.WriteLine(paddedCode);
}




