using LINQ_Assignment001.Data;
using System.Text.RegularExpressions;
using static LINQ_Assignment001.ListGenerator;

namespace LINQ_Assignment001
{
    internal class Program
    {
      
        static void Main(string[] args)
        {
            #region Restriction Operator

            #region Q1
            //var outofstock = ProductList.Where(p => p.UnitsInStock == 0);
            //Console.WriteLine(string.Join("\n", outofstock.ToList()));
            #endregion

            #region  Q2
            //var instock = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //Console.WriteLine(string.Join("\n", instock.ToList()));
            #endregion

            #endregion


            #region Element Operators

            #region Q1
            //var FirstProduct=ProductList.FirstOrDefault(p=>p.UnitsInStock==0);
            //Console.WriteLine(FirstProduct);
            #endregion

            #region Q2
            //var FirstProduct = ProductList.FirstOrDefault(p => p.UnitPrice >1000);
            //Console.WriteLine(FirstProduct);
            #endregion

            #region Q3
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var number =Arr.Where(n=>n>5).Skip(1).FirstOrDefault();
            //Console.WriteLine(number);
            #endregion


            #endregion

            #region Aggregate Operators
            #region Q1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var oddNums=Arr.Count(n=>n%2!=0);
            //Console.WriteLine(oddNums);
            #endregion

            #region Q2

            //var customerorders = CustomerList.Select(c => new
            //{
            //    customername = c.CustomerName,
            //    ordercount = c.Orders.Count()
            //});
            //foreach (var item in customerorders)
            //{
            //    Console.WriteLine($"Customer: {item.customername}, Orders: {item.ordercount}");
            //}
            #endregion

            #region Q3
            //var categoryCounts =ProductList
            //.GroupBy(c => c.Category)
            //.Select(p => new { Category = p.Key, ProductCount = p.Count() })
            //.ToList();

            //foreach (var category in categoryCounts)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Product Count: {category.ProductCount}");
            //}
            #endregion

            #region Q4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //int sum=Arr.Sum();
            //Console.WriteLine(sum);
            #endregion

            #region Q9
            //var Total = ProductList.GroupBy(c => c.Category).Select(n => new
            //{
            //    Category = n.Key,
            //    TotalInstock = n.Sum(p => p.UnitsInStock),
            //});

            //foreach (var item in Total)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units in Stock: {item.TotalInstock}");
            //}

            #endregion

            #region Q10
            //var Cheapest = ProductList.GroupBy(c => c.Category)
            //    .Select(g => new
            //    {
            //        category = g.Key,
            //        CheapestPrice = g.Min(p => p.UnitPrice)
            //    });

            //foreach (var item in Cheapest)
            //{
            //    Console.WriteLine($"Category: {item.category}, Cheapest Price: {item.CheapestPrice}");
            //}
            #endregion

            #region Q11
            //var cheapest =from p in ProductList
            //              group p by p.Category into g
            //              let minprice=g.Min(p=>p.UnitPrice)
            //              from p in g
            //              where p.UnitPrice == minprice
            //              select p;

            //foreach (var product in cheapest)
            //{
            //    Console.WriteLine($"Category: {product.Category}, Product: {product.ProductName}, Price: {product.UnitPrice}");
            //}

            #endregion

            #region Q12
            //var Expensive = ProductList.GroupBy(c => c.Category)
            //    .Select(g => new
            //    {
            //        category = g.Key,
            //        ExpensivePrice = g.Max(p => p.UnitPrice)
            //    });

            //foreach (var item in Expensive)
            //{
            //    Console.WriteLine($"Category: {item.category}, Cheapest Price: {item.ExpensivePrice}");
            //}
            #endregion

            #region Q13
            //var expensiveProducts = ProductList
            //        .GroupBy(p => p.Category)
            //        .SelectMany(g => g.Where(p => p.UnitPrice == g.Max(p => p.UnitPrice)));

            //foreach (var product in expensiveProducts)
            //{
            //    Console.WriteLine($"Category: {product.Category}, Product: {product.ProductName}, Price: {product.UnitPrice}");
            //}

            #endregion

            #region Q14
            //var AvgPrice = ProductList.GroupBy(c => c.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    AVGPrice = g.Average(p => p.UnitPrice)
            //});

            //foreach (var item in AvgPrice)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Avg Price: {item.AVGPrice}");
            //}
            #endregion


            #endregion

            #region Ordering Operators

            #region Q1
            //var orderedProducts=ProductList.OrderBy(p=>p.ProductName).ToList();
            //Console.WriteLine(string.Join("\n", orderedProducts.ToList()));
            #endregion

            #region Q2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRrY" };

            //var sortedwords =Arr.OrderBy(s=>s,StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine(string.Join("\n", sortedwords.ToList()));

            #endregion

            #region Q3
            //var sortedProducts = ProductList.OrderByDescending(p => p.UnitsInStock);
            //Console.WriteLine(string.Join("\n", sortedProducts.ToList()));

            #endregion

            #region Q4
            //string[] digitArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var sortedDigits=digitArr.OrderBy(d=>d.Length).ThenBy(d=>d);
            //Console.WriteLine(string.Join("\n", sortedDigits.ToList()));
            #endregion

            #region Q5
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRrY" };
            //var Sortedwords =Arr.OrderBy(x=>x.Length).ThenBy(s=>s,StringComparer.OrdinalIgnoreCase).ToList();
            //Console.WriteLine(string.Join("\n", Sortedwords));
            #endregion

            #region Q6
            //var sortedProducts = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice).ToList();
            //Console.WriteLine(string.Join("\n", sortedProducts));
            #endregion

            #region Q7
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRrY" };
            //var Sortedwords = Arr.OrderBy(x => x.Length).ThenByDescending(s => s, StringComparer.OrdinalIgnoreCase).ToList();
            //Console.WriteLine(string.Join("\n", Sortedwords));

            #endregion

            #endregion

            #region Transformation Operators
            #region Q1
            //var productNames = ProductList.Select(p => p.ProductName).ToList();
            //Console.WriteLine(string.Join("\n", productNames));
            #endregion

            #region Q2
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRrY" };

            //var NewWords = words.Select(w => new
            //{
            //    Upper = w.ToUpper(),
            //    Lower = w.ToLower(),
            //});
            //foreach (var word in NewWords) 
            //{
            //    Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
            //}
            #endregion

            #region Q3
            //var productPrices = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice });
            //Console.WriteLine(string.Join("\n", productPrices));
            #endregion

            #region Q4
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var matches = arr.Select((num, index) => new { Number = num, InPlace = num == index });

            //foreach (var match in matches)
            //{
            //    Console.WriteLine($"{match.Number}: {match.InPlace}");
            //}
            #endregion

            #region Q5
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs= from a in numbersA
            //           from b in numbersB
            //           where a<b
            //           select new {A=a, B=b};

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.A} is less than {pair.B}");
            //}
            #endregion

            #region Q6
            //var smallestOrder = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);

            //foreach (var order in smallestOrder)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, Total: {order.Total}");
            //}
            #endregion

            #region Q7
            //var recentOrders = CustomerList
            //    .SelectMany(c => c.Orders)
            //    .Where(o => o.OrderDate.Year >= 1998);

            //foreach (var order in recentOrders)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, Date: {order.OrderDate}");
            //}
            #endregion


            #endregion

            #region Set Operators

            #region Q1
            //var uniqueproducts = ProductList.Select(p => p.Category).Distinct();
            //Console.WriteLine(string.Join("\n", uniqueproducts));
            #endregion

            #region Q2
            //var firstletter = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
            //Console.WriteLine(string.Join("\n", firstletter));

            #endregion

            #region Q3
            //var Commonfirstletter = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
            //Console.WriteLine(string.Join("\n", Commonfirstletter));
            #endregion

            #region Q4
            //var uniquefirstletter = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
            //Console.WriteLine(string.Join("\n", uniquefirstletter));
            #endregion

            #region Q5

            #endregion
            #endregion

            #region Quatifiries
            #region Q2
            //var group = ProductList.GroupBy(c => c.Category).Where(g => g.Any(p => p.UnitsInStock == 0)).ToList();
            //foreach (var categoryGroup in group)
            //{
            //    Console.WriteLine($"\nCategory: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"  - {product.ProductName} (Stock: {product.UnitsInStock})");
            //    }
            //}


            #endregion

            #region Q3
            //var group = ProductList.GroupBy(c => c.Category).Where(g => g.All(p => p.UnitsInStock > 0)).ToList();
            //foreach (var categoryGroup in group)
            //{
            //    Console.WriteLine($"\nCategory: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"  - {product.ProductName} (Stock: {product.UnitsInStock})");
            //    }
            //}

            #endregion
            #endregion

            #region Partitioning Operators

            #region Q1
            //var orders=CustomerList.Where(x=>x.Region== "Washington").SelectMany(c=>c.Orders).Take(3);

            //Console.WriteLine(string.Join("\n", orders));


            #endregion

            #region Q2
            //var orders = CustomerList.Where(x => x.Region == "Washington").SelectMany(c => c.Orders).Skip(2);
            //Console.WriteLine(string.Join("\n", orders));

            #endregion

            #region Q3
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var newNumbers=numbers.TakeWhile((n,index)=>n>index);
            //Console.WriteLine(string.Join("\n", newNumbers));

            #endregion

            #region Q4
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var elemnts = numbers.SkipWhile(n => n % 3 != 0);
            //Console.WriteLine(string.Join("\n", elemnts));

            #endregion
            #endregion

            #region Grouping Operrators
            #region Q1
            //List<int> Numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            //var groupednumbers = Numbers.GroupBy(n => n % 5).OrderBy(n => n.Key);
            //foreach (var group in groupednumbers)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var number in group)
            //    {
            //        Console.WriteLine(number);
            //    }
            //}
            #endregion

            #region Q3
            string[] words = { "from", "salt", "earn", "last", "near", "form" };
            var groupedWords = words.GroupBy(w => string.Concat(w.OrderBy(c => c)));
            foreach (var groupedWord in groupedWords)
            {
                foreach (var word in groupedWord)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine("....");

            }



            #endregion
            #endregion
        }
    }
}

//Console.WriteLine(string.Join("\n", productNames));

//Console.WriteLine(string.Join("\n", FirstProduct.ToList()));
