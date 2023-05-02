using System.Collections;
using System.Diagnostics;
using System.Reflection;
using System.Xml.Serialization;

namespace DocxEx.Test;

/// <summary>
/// Base class for all test.
/// </summary>
public class TestBase
{
  /// <summary>
  /// Setups the test path. Can be overriden in descendant classes.
  /// </summary>
  [SetUp]
  public virtual void Setup()
  {
    var testPath = Assembly.GetExecutingAssembly().Location;
    testPath = testPath.Substring(0, testPath.IndexOf(@"\bin")) + @"\SampleDocs";
    //WriteLine(testPath);
    TestPath = testPath;
  }

  /// <summary>
  /// Gets or sets the test path that is used to read/write test data files.
  /// </summary>
  /// <value>
  /// The test path.
  /// </value>
  public string TestPath { get; set; } = string.Empty;

  /// <summary>
  /// Writes the line to debug output window and test explorer output window.
  /// </summary>
  /// <param name="str">Line of text. Can be empty</param>
  protected void WriteLine(string? str = "")
  {
    Debug.WriteLine(str);
    TestContext.Out.WriteLine(str);
  }

  /// <summary>
  /// Dumps the object to text explorer progress window.
  /// </summary>
  /// <param name="heading">A heading line to write.</param>
  /// <param name="value">The object to dump.</param>
  /// <param name="indent">The indent of text.</param>
  protected void ShowObject(string heading, object? value, int indent = 0)
  {
    if (value is null)
      return;
    var type = value.GetType();
    var indentStr = new string(' ', (indent + 2) * 2);
    if (type.IsClass && type != typeof(string))
    {
      TestContext.Progress.WriteLine(indentStr + $"{heading}");
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
      TestContext.Progress.WriteLine(indentStr + $"{heading} = {value}");
  }

  /// <summary>
  /// Dumps the enumerable collection to test explorer output window.
  /// </summary>
  /// <param name="heading">A heading line to write.</param>
  /// <param name="value">Collection to dump.</param>
  /// <param name="itemType">Type of the collection item.</param>
  /// <param name="indent">The indent of text</param>
  protected void ShowEnumerable(string heading, IEnumerable? value, Type? itemType, int indent = 0)
  {
    if (value is null)
      return;
    var type = value.GetType();
    var arg = type.GetGenericArguments().FirstOrDefault();
    var indentStr = new string(' ', (indent + 2) * 2);
    TestContext.Progress.WriteLine(indentStr + $"{heading}");
    int itemCount = 0;
    foreach (var item in value)
      ShowObject($"[{itemCount++}] {item.GetType().Name}", item, indent + 1);
  }

    /// <summary>
  /// Dumps the enumerable collection to test explorer output window.
  /// </summary>
  /// <param name="value">Collection to dump.</param>
  /// <param name="itemType">Type of the collection item.</param>
  /// <param name="indent">The indent of text</param>
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