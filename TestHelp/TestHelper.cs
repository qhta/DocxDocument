using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Xml;

using Qhta.TypeUtils;

namespace DocumentModel;

/// <summary>
/// Provides helper methods for test scenarios.
/// </summary>
public static class TestHelper
{

  /// <summary>
  /// Compares two test data instances property by property.
  /// </summary>
  /// <param name="obj1">First test data instance</param>
  /// <param name="obj2">Second test data instance</param>
  /// <param name="propName">Name of the property that differs, if any</param>
  /// <returns>True if the properties are equal, false otherwise</returns>
  public static bool CompareTestData<T>(T obj1, T obj2, out string? propName)
  {
    return CompareTestData(typeof(T), obj1, obj2, out propName);
  }

  /// <summary>
  /// Compares the public writable properties of two objects of the specified type for deep equality.
  /// </summary>
  /// <remarks>If the specified type represents a collection, the method compares the elements recursively in
  /// order. The comparison uses deep equality, including nested properties and collection items. The method does not
  /// compare indexer properties or properties that are read-only.</remarks>
  /// <typeparam name="T">The type of the objects to compare.</typeparam>
  /// <param name="comparedType">The type whose public writable properties are compared between the two objects. Must not be null.</param>
  /// <param name="obj1">The first object to compare. Must be of the specified type.</param>
  /// <param name="obj2">The second object to compare. Must be of the specified type.</param>
  /// <param name="propName">When the method returns <see langword="false"/>, contains the name of the first property or collection element
  /// that differs; otherwise, <see langword="null"/>.</param>
  /// <returns><see langword="true"/> if all public writable properties of the two objects are equal; otherwise, <see
  /// langword="false"/>.</returns>
  public static bool CompareTestData<T>(Type comparedType, T obj1, T obj2, out string? propName)
  {
    propName = null;
    return CompareTestData1(comparedType, obj1, obj2, ref propName);
  }
  /// <summary>
  /// The actual implementation of CompareTestData with ref parameter for propName.
  /// </summary>
  private static bool CompareTestData1<T>(Type comparedType, T obj1, T obj2, ref string? propName)
  {
    bool result;

    if (obj1 == null && obj2 == null) return true;
    if (obj1 == null || obj2 == null) return false;
    comparedType = comparedType.GetNotNullableType();
    if (comparedType.IsEnum)
    {
      result = object.Equals(obj1, obj2);
      if (!result)
        return false;
      return result;
    }
    if (comparedType.Implements(typeof(IEquatable<T>)))
    {
      result = Object.Equals(obj1, obj2);
      if (!result)
        return false;
      return result;
    }

    foreach (var property in comparedType.GetProperties())
    {
      if (propName=="LatentStyles") Debug.Assert(true);
      if (property.CanWrite && property.GetIndexParameters().Length == 0 && !property.IsDefined(typeof(NotMappedAttribute), true))
      {
        propName = /*property.DeclaringType?.Name +"."+ */property.Name;
        var obj1Value = property.GetValue(obj1);
        var obj2Value = property.GetValue(obj2);

        if (comparedType.IsValueType)
        {
          result = Comparer.Equals(obj1Value, obj2Value);
          if (!result)
            return false;
        }
        else
        {

          var equatableType = typeof(IEquatable<>).MakeGenericType(property.PropertyType);
          if (equatableType.IsInstanceOfType(obj1Value))
          {
            var equalsMethod = equatableType.GetMethod("Equals", [property.PropertyType]);
            result = (bool)equalsMethod!.Invoke(obj1Value, [obj2Value])!;
            if (result)
              continue;
          }
          if (!CompareTestData1(property.PropertyType, obj1Value, obj2Value, ref propName))
          {
            if (obj1Value is bool boolObj1Value)
            {
              if (boolObj1Value == false && obj2Value is null)
                continue;
            }
            if (obj1Value is null && obj2Value is IEnumerable enumerable2 && !enumerable2.Cast<object>().Any())
              continue;
            if (obj2Value is null && obj1Value is IEnumerable enumerable1 && !enumerable1.Cast<object>().Any())
              continue;
            return false;
          }
        }
      }
    }
    result = true;
    if (comparedType == typeof(string))
    {
      string? obj1String = obj1.ToString();
      string? obj2String = obj2.ToString();
      result = string.Equals(obj1String, obj2String);
      return result;
    }
    if (comparedType.IsEnumerable(out var itemType) && obj1 is IEnumerable obj1Enumerable
                                                    && obj2 is IEnumerable obj2Enumerable)
    {
      var enumerator1 = obj1Enumerable.GetEnumerator();
      var enumerator2 = obj2Enumerable.GetEnumerator();
      int itemCount = 0;
      while (enumerator1.MoveNext() && enumerator2.MoveNext())
      {
        if (!CompareTestData(itemType, enumerator1.Current, enumerator2.Current, out var itemPropName))
        {
          propName = $"{itemType.Name}[{itemCount}].{itemPropName}";
          result = false;
          break;
        }
      }
      if (result)
      {
        result = !enumerator1.MoveNext() && !enumerator2.MoveNext();
        if (!result)
          propName = $"{comparedType}.Count";
      }
      (enumerator1 as IDisposable)?.Dispose();
      (enumerator2 as IDisposable)?.Dispose();
    }

    return result;
  }

  /// <summary>
  /// Changes test data in the given instance.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="instance">The test data to modify.</param>
  public static void ChangeTestData<T>(T instance)
  {
    if (instance == null)
      throw new ArgumentNullException(nameof(instance));  
    var properties = typeof(T).GetProperties().Where(prop => prop.CanWrite);
    foreach (var prop in properties)
    {
      var propType = prop.PropertyType.GetNotNullableType();
      // Update each property with new test data
      if (prop.PropertyType == typeof(bool))
      {
        prop.SetValue(instance, Random.Shared.NextDouble() < 0.5);
      }
      else if (prop.PropertyType == typeof(int))
      {
        prop.SetValue(instance, Random.Shared.Next());
      }
      else if (prop.PropertyType == typeof(HexInt))
      {
        prop.SetValue(instance, new HexInt(Random.Shared.Next()));
      }
      else if (prop.PropertyType == typeof(string))
      {
        prop.SetValue(instance, prop.GetValue(instance) + " updated");
      }
      else if (prop.PropertyType == typeof(DateTime))
      {
        prop.SetValue(instance, DateTime.Now);
      }
    }
  }

  /// <summary>
  /// Changes a boolean property value for testing purposes.
  /// </summary>
  /// <param name="obj">The object containing the property.</param>
  /// <param name="prop">The property to change.</param>
  /// <returns>The new value of the property.</returns>
  /// <remarks>
  /// If the property is null, a random boolean value will be returned.
  /// Otherwise, the boolean value will be toggled.
  /// </remarks>
  static bool? ChangeBoolProperty(object obj, PropertyInfo prop)
  {
    var value = prop.GetValue(obj);
    if (value == null)
      return Random.Shared.NextDouble() < 0.5;
    else
    if (value is bool boolValue)
      return !boolValue;
    return (bool?)value;
  }

  /// <summary>
  /// Changes the value of an integer property on the specified object and returns the new value.
  /// </summary>
  /// <param name="obj">The object whose property value is to be changed. Must not be null.</param>
  /// <param name="prop">The property to change. Must be a readable property of <paramref name="obj"/>.</param>
  /// <returns>A nullable integer representing the new value of the property.</returns>
  /// <remarks>If the original value is null, returns a random integer.
  /// If the original value is an integer, returns its value incremented by one.
  /// </remarks>remarks
  static int? ChangeIntProperty(object obj, PropertyInfo prop)
  {
    var value = prop.GetValue(obj);
    if (value == null)
      return Random.Shared.Next();
    else
    if (value is int intValue)
      return intValue + 1;
    return (int?)value;
  }

  /// <summary>
  /// Copies test data from one instance to another.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="fromInstance">The instance to copy data from.</param>
  /// <param name="toInstance"></param>
  public static void CopyTestData<T>(T fromInstance, T toInstance)
  {
    var properties = typeof(T).GetProperties().Where(prop => prop.CanRead && prop.CanWrite);
    foreach (var prop in properties)
    {
      var value = prop.GetValue(fromInstance);
      prop.SetValue(toInstance, value);
    }
  }

  /// <summary>
  /// Retrieves a formatted string containing the messages of all inner exceptions for the specified exception.
  /// </summary>
  /// <remarks>This method is useful for logging or displaying detailed error information, especially when
  /// exceptions are nested. The returned string includes each inner exception message on a separate line.</remarks>
  /// <param name="ex">The exception from which to extract inner exception messages. Cannot be null.</param>
  /// <returns>A string listing the messages of all inner exceptions, each prefixed with "Inner Exception:". Returns "No inner
  /// exceptions" if there are none.</returns>
  public static string GetInternalMessages(this Exception ex)
  {
    var internalException = ex.InnerException;
    var messages = new List<string>();
    while (internalException != null)
    {
      messages.Add($"   Inner Exception: {internalException.Message}");
      internalException = internalException.InnerException;
    }
    return messages.Count > 0 ? string.Join("\n", messages) : "No inner exceptions";
  }


  /// <summary>
  /// Formats XML string with line numbers for easier debugging.
  /// </summary>
  /// <param name="xml"></param>
  /// <returns></returns>
  public static string FormatXmlWithLineNumbers(this string xml)
  {
    var xmlDoc = new XmlDocument();
    using (var reader = XmlReader.Create(new StringReader(xml)))
    {
      xmlDoc.Load(reader);
    }

    var writerSettings = new XmlWriterSettings
    {
      Indent = true,
      NewLineHandling = NewLineHandling.Replace,
      NewLineChars = Environment.NewLine,
      OmitXmlDeclaration = false
    };

    using var stringWriter = new StringWriter();
    using (var xmlWriter = XmlWriter.Create(stringWriter, writerSettings))
    {
      xmlDoc.Save(xmlWriter);
    }

    var formattedXml = stringWriter.ToString();
    var lines = formattedXml.Split(["\r\n", "\n", "\r"], StringSplitOptions.None);
    var builder = new StringBuilder(formattedXml.Length + lines.Length * 8);
    for (int i = 0; i < lines.Length; i++)
    {
      builder.Append((i + 1).ToString().PadLeft(4));
      builder.Append(": ");
      builder.AppendLine(lines[i]);
    }
    return builder.ToString();
  }
}