using Singleton;

///
/// singleTonl دا مثال عن ال  
/// من خلال المثال هعمل تغيير للعملة من عملة لاخري عن طريق كلاس وسيط 
///بحيث استدعيه مرة واحده بس  SingleTon هعمل الكلاس انه يكون  
///
Console.WriteLine("Enter the base currency");
var baseCurrency = Console.ReadLine();
Console.WriteLine("Enter the Target currency");
var targetCurrency = Console.ReadLine();
Console.WriteLine("Enter the Amount");
var amount = decimal.Parse(Console.ReadLine());
var exchangedAmmount = CurrencyConverter.Instance.Convert(baseCurrency, targetCurrency, amount);
Console.WriteLine($"{amount} {baseCurrency} = {exchangedAmmount} {targetCurrency}");
