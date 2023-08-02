int[] nums = { 10, 2330, 112233, 12, 949, 3764, 2942, 523863 };
//1
var min = nums.Where(x => x == nums.Min(y => y)).FirstOrDefault();
Console.WriteLine(min);
//2
var max = nums.Where(x=>x == nums.Max(y => y)).FirstOrDefault();
Console.WriteLine(max);
//3
var lessThan10k = nums.Where(x => x < 10000).Max();
Console.WriteLine(lessThan10k);
//4
var bt10n100 = nums.Where(x => x > 10).Where(x => x < 100);
foreach(var x in bt10n100) Console.WriteLine(x);
//5
var bt100kn99k = nums.Where(x => x >= 100000).Where(x => x <= 999999);
foreach(var x in bt100kn99k) Console.WriteLine(x);
//6
var even = nums.Where(x => x % 2 == 0);
foreach (var x in even) Console.WriteLine(x);