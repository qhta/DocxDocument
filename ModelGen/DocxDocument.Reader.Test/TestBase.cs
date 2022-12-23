using System.Collections;
using System.Reflection;
using System.Xml.Serialization;

namespace DocxDocument.Reader.Test;

public class TestBase
{
  [SetUp]
  public virtual void Setup()
  {
    var testPath = Assembly.GetExecutingAssembly().Location;
    testPath = testPath.Substring(0, testPath.IndexOf(@"\bin")) + @"\SampleDocs";
    TestContext.Progress.WriteLine(testPath);
    TestPath = testPath;
  }

  public string TestPath { get; set; } = string.Empty;

  protected void ShowObject(string name, object? value, int indent = 0)
  {
    if (value is null)
      return;
    var type = value.GetType();
    var indentStr = new string(' ', (indent + 2) * 2);
    if (type.IsClass && type != typeof(string))
    {
      TestContext.Progress.WriteLine(indentStr + $"{name}");
      var typeProperties = type.GetProperties();
      var propsListed = false;
      foreach (var prop in typeProperties)
      {
        if (prop.GetIndexParameters().Length == 0)
        {
          if (prop.GetCustomAttribute<XmlIgnoreAttribute>() is null)
          {
            if (prop.PropertyType.Name == "IEnumerable`1")
            {
              propsListed = true;
              var arg = prop.PropertyType.GetGenericArguments().FirstOrDefault();
              ShowEnumerable(prop.Name, prop.GetValue(value, null) as IEnumerable, arg, indent + 1);
            }
            else
            {
              propsListed = true;
              ShowObject(prop.Name, prop.GetValue(value, null), indent + 1);
            }
          }
        }
      }
      if (!propsListed)
      {
        var intfType = value.GetType().GetInterface("IEnumerable`1");
        if (intfType is not null)
        {
          var arg = intfType.GetGenericArguments().FirstOrDefault();
          ShowEnumerable(value as IEnumerable, arg, indent + 1);
        }
      }
    }
    else
      TestContext.Progress.WriteLine(indentStr + $"{name} = {value}");
  }

  protected void ShowEnumerable(string name, IEnumerable? value, Type? itemType, int indent = 0)
  {
    if (value is null)
      return;
    var type = value.GetType();
    var arg = type.GetGenericArguments().FirstOrDefault();
    var indentStr = new string(' ', (indent + 2) * 2);
    TestContext.Progress.WriteLine(indentStr + $"{name}");
    int itemCount = 0;
    foreach (var item in value)
      ShowObject($"[{itemCount++}] {item.GetType().Name}", item, indent + 1);
  }

  protected void ShowEnumerable(IEnumerable? value, Type? itemType, int indent = 0)
  {
    if (value is null)
      return;
    var indentStr = new string(' ', (indent + 2) * 2);
    int itemCount = 0;
    foreach (var item in value)
      ShowObject($"[{itemCount++}] {item.GetType().Name}", item, indent + 1);
  }
}