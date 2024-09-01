// (Property) مثال عن تاجير عقار 
using Builder;

// خطا
//var properity1 = new Property("cairo", TransactionType.Rent, PropertyType.House, 2, 129, 100, 3, 3, 1999, false, true, true, false, false);
//var properity2 = new Property("Alex", TransactionType.Rent, PropertyType.House , 120);

var properity1 = new PropertyBuilder().SetAddress("Cairo").SetFloorArea(123).SetPrice(30_000) .Build();
// Throw Exception As I put restirections to must set val for address and price
var properity2 = new PropertyBuilder().SetAddress("Cairo").SetFloorArea(123).Build();