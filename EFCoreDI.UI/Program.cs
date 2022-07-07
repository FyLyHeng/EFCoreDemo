// See https://aka.ms/new-console-template for more information


using System.Reflection;
using EFCoreDI.Service;
using EFCoreDI.UI;
using Service = EFCoreDI.Service.DI.ServiceRegistration;
using DynamicFun = EFCoreDI.UI.DI.ServiceRegistration;
Console.WriteLine("Hello, World!");
Service.RegisterServices();
DynamicFun.RegisterServices();

IEmployeeService employeeService = Service.GetService<IEmployeeService>();
//IInvoiceService invoiceService = ServiceRegistration.GetService<IInvoiceService>();
employeeService.Display();
// var inv = new Invoice
// {
//     InvoiceNo = "INV_001",
//     Employee = employeeService.Get(1)
// };
//invoiceService.Add(inv);
//employeeService.Display();

/*
Type? type = Type.GetType("EFCoreDI.UI.Clear");
Console.WriteLine($"why,, {type?.GetType().Name}");

var data = "";
type?.GetProperty("_Instance")?.GetValue(data);
*/

// var type = Type.GetType("EFCoreDI.UI.Clear");
// var Instance = type.GetProperty("_Instance").GetValue(type);
// var s = type.GetMethod("Do");
// s.Invoke(Instance, new object[] {});






/*
 // work
 
 
var type = Type.GetType("EFCoreDI.UI.Clear");
var myObject = (Clear)Activator.CreateInstance(type);
var s = type.GetMethod("Do");
s.Invoke(myObject, new object[] {});*/



 /*
 var typea = Type.GetType("EFCoreDI.UI.Clear");
object instance = Activator.CreateInstance(null,typea)!;

 MethodInfo? theMethod = typea?.GetMethod("Do");
theMethod?.Invoke(instance, Array.Empty<object>());
*/





//======
// // var type = Type.GetType("EFCoreDI.UI.Clear");
// // object instance = Activator.CreateInstance(type!)!;
// // MethodInfo? theMethod = type?.GetMethod("Do");
// // theMethod?.Invoke(instance, Array.Empty<object>());


//Type me = Type.GetType("EFCoreDI.UI.Clear");
// MethodInfo method = me.GetMethod("NotDo", BindingFlags.Static | BindingFlags.Public);
//
// method.Invoke(null, null);



// MethodInfo? method = typeof(Clear).GetMethod("Do");
// FieldInfo? field = typeof(Clear).GetField("_Instance", BindingFlags.Static | BindingFlags.Public);
// object? instance = field?.GetValue(null);
//
//
// method?.Invoke(instance, new object[] {});
//
//
//
// Clear.Instance().Do();
// Clear.Instance().Do();

IDynamicFun? fun = DynamicFun.GetService(Type.GetType("EFCoreDI.UI.Clear")) as IDynamicFun;
IDynamicFun? fun1 = DynamicFun.GetService(Type.GetType("EFCoreDI.UI.MyDelete")) as IDynamicFun;
fun.Do();
fun.Do();
fun1.Do();
fun1.Do();

//DynamicFun.GetIService<Clear>().Do();


