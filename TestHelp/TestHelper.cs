using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

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
  /// <param name="firstName">Name of the first object (for message generating)</param>
  /// <param name="secondName">Name of the second object (for message generating)</param>
  /// <param name="message">Message describing the difference, if any</param>
  /// <returns>True if the properties are equal, false otherwise</returns>
  public static bool CompareTestData<T>(T obj1, T obj2, string firstName, string secondName, out string? message)
  {
    return CompareTestData(typeof(T), obj1, obj2, firstName, secondName, out message);
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
  /// <param name="firstName">Name of the first object (for message generating)</param>
  /// <param name="secondName">Name of the second object (for message generating)</param>
  /// <param name="message">Message describing the difference, if any</param>
  /// <returns><see langword="true"/> if all public writable properties of the two objects are equal; otherwise, <see
  /// langword="false"/>.</returns>
  public static bool CompareTestData<T>(Type comparedType, T obj1, T obj2, string firstName, string secondName, out string? message)
  {
    if (comparedType.Name=="Variant")
      Debug.Assert(true);
    bool result;
    message = null;
    if (obj1 == null && obj2 == null) return true;
    if (obj1 == null && obj2 != null) { message = $"{firstName} is null and {secondName} is {obj2}"; return false; }
    if (obj2 == null && obj1 != null) { message = $"{secondName} is null and {firstName} is {obj1}"; return false; }
    comparedType = comparedType.GetNotNullableType();
    if (comparedType.IsEnum)
    {
      result = object.Equals(obj1, obj2);
      if (!result)
        message = $"Enum values differ -> {firstName}={obj1} vs {secondName}={obj2}";
      return result;
    }
    if (comparedType.Implements(typeof(IEquatable<T>)))
    {
      result = Object.Equals(obj1, obj2);
      if (!result)
        message = $"Objects of type {comparedType.Name} differ: {firstName}={obj1} vs {secondName}={obj2}";
      return result;
    }

    foreach (var property in comparedType.GetProperties())
    {
      if (property.CanWrite && property.GetIndexParameters().Length == 0 && !property.IsDefined(typeof(NotMappedAttribute), true))
      {
        var propName = /*property.DeclaringType?.Name +"."+ */property.Name;
        var obj1Value = property.GetValue(obj1);
        var obj2Value = property.GetValue(obj2);

        if (comparedType.IsValueType)
        {
          result = Comparer.Equals(obj1Value, obj2Value);
          if (!result)
            message = $"Property {propName} values differ -> {firstName}={obj1Value} vs {secondName}={obj2Value}";
          return result;
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
          if (!CompareTestData(property.PropertyType, obj1Value, obj2Value, firstName, secondName, out var nestedMessage))
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
            message = $"Property {propName} values differ -> {nestedMessage}";
            return false;
          }
        }
      }
    }
    result = true;
    if (comparedType == typeof(string))
    {
      string? obj1String = obj1?.ToString();
      string? obj2String = obj2?.ToString();
      result = string.Equals(obj1String, obj2String);
      message = result ? null : $"String values differ -> '{obj1String}' vs '{obj2String}'";
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
        var item1 = enumerator1.Current;
        var item2 = enumerator2.Current;
        if (!CompareTestData(itemType, item1, item2, firstName, secondName, out var internalMessage))
        {
          message = $"{itemType.Name}[{itemCount}] differ -> {internalMessage}";
          result = false;
          break;
        }
        itemCount++;
      }
      if (result)
      {
        if (enumerator1.MoveNext())
        {
          if (itemCount == 0)
            message = $"{secondName} has no items";
          else
            message = $"{firstName} has more items than {secondName}";
          result = false;
        }
        else
          if (enumerator2.MoveNext())
          {
            if (itemCount == 0)
              message = $"{firstName} has no items";
            else
              message = $"{secondName} has more items than {firstName}";
            result = false;
          }
      }
      (enumerator1 as IDisposable)?.Dispose();
      (enumerator2 as IDisposable)?.Dispose();
    }
    else
    {
      var equatableType = typeof(IEquatable<>).MakeGenericType(comparedType);
      if (comparedType.Implements(equatableType))
      {
        var equalsMethod = equatableType.GetMethod("Equals", [comparedType]);
        equalsMethod ??= comparedType.GetMethod("Equals", [comparedType]);
        if (equalsMethod == null)
          throw new InvalidOperationException($"Type {comparedType.Name} implements IEquatable<{comparedType.Name}> but does not have an Equals method.");
        result = (bool)equalsMethod.Invoke(obj1, [obj2])!;
        if (!result)
          message = $"Values of type {comparedType.Name} differ -> {firstName}={obj1} vs {secondName}={obj2}";
        if (!result)
          return false;
      }
    }

    return result;
  }

  /// <summary>
  /// Populates test data in the given instance.
  /// </summary>
  /// <param name="instance">The test data to modify.</param>
  /// <param name="index">Optional index number</param>
  public static void PopulateTestData(object instance, int index=-1)
  {
    if (instance == null)
      throw new ArgumentNullException(nameof(instance));
    //Debug.WriteLine($"Populating test data for instance of type {instance.GetType().Name}");
    var properties = instance.GetType().GetProperties()
      .Where(prop => !prop.IsIndexer() && prop.CanWrite && prop.GetCustomAttribute<NotMappedAttribute>()==null);
    foreach (var prop in properties)
    {
      var propType = prop.PropertyType.GetNotNullableType();
      //Debug.WriteLine($"Populating property: {prop.Name} of type {propType}");
      // Set each property with new test data
      if (propType == typeof(string))
      {
        prop.SetValue(instance, "Sample " + prop.Name + (index >= 0 ? $" {index + 1}" : ""));
      }
      else if (propType == typeof(bool))
      {
        prop.SetValue(instance, Random.Shared.NextDouble() < 0.5);
      }
      else if (propType == typeof(Int32))
      {
        prop.SetValue(instance, Random.Shared.Next());
      }
      else if (propType == typeof(UInt32))
      {
        prop.SetValue(instance, (UInt32)Random.Shared.NextInt64(0,UInt32.MaxValue));
      }
      else if (propType == typeof(Int16))
      {
        prop.SetValue(instance, (Int16)(Random.Shared.Next(0, Int16.MaxValue)));
      }
      else if (propType == typeof(UInt16))
      {
        prop.SetValue(instance, (UInt16)(Random.Shared.Next(0, UInt16.MaxValue)));
      }
      else if (propType == typeof(Int64))
      {
        prop.SetValue(instance, Random.Shared.NextInt64());
      }
      else if (propType == typeof(UInt64))
      {
        prop.SetValue(instance, (UInt64)Random.Shared.NextInt64(0, (long)Int64.MaxValue));
      }
      else if (propType == typeof(HexInt))
      {
        prop.SetValue(instance, new HexInt(Random.Shared.Next()));
      }
      else if (propType == typeof(HexBinary))
      {
        prop.SetValue(instance, CreateHexBinary(Random.Shared.Next()));
      }
      else if (propType == typeof(DateTime))
      {
        prop.SetValue(instance, DateTime.Now);
      }
      else if (propType.IsEnum)
      {
        var enumValues = Enum.GetValues(propType);
        var randomValue = enumValues.GetValue(Random.Shared.Next(enumValues.Length));
        prop.SetValue(instance, randomValue);
      }
      else if (propType == typeof(Guid))
      {
        prop.SetValue(instance, Guid.NewGuid());
      }
      else if (propType == typeof(Percent))
      {
        prop.SetValue(instance, new Percent(Random.Shared.NextDouble() * 100));
      }
      else if (propType == typeof(Decimal))
      {
        prop.SetValue(instance, new Decimal(Random.Shared.NextDouble() * 100));
      }
      else if (propType == typeof(Double))
      {
        prop.SetValue(instance, Random.Shared.NextDouble() * 100);
      }
      else if (propType == typeof(Single))
      {
        prop.SetValue(instance, (float)Random.Shared.NextDouble() * 100);
      }
      else if (propType == typeof(Variant))
      {
        prop.SetValue(instance, CreateVariant(VariantSupportedTypes[Random.Shared.Next(VariantSupportedTypes.Length)]));
      }
      else if (propType.IsClass && propType != typeof(string))
      {
        if (!propType.IsAbstract)
        {
          // For complex types, recursively change their properties
          var nestedInstance = prop.GetValue(instance);
          if (nestedInstance == null)
          {
            nestedInstance = Activator.CreateInstance(propType);
            prop.SetValue(instance, nestedInstance);
          }
          PopulateTestData(nestedInstance!);
        }
      }
      else
      {
        throw new NotSupportedException($"Property type {propType} is not supported for PopulateTestData.");
      }
    }

    if (instance.GetType().IsEnumerable(out var elementType)
        && !elementType.IsAbstract)
    {
      var n = Random.Shared.Next(2, 5); // Random number of elements to add

      if (elementType == typeof(string))
      {
        for (var i = 0; i < n; i++)
        {
          var elementInstance = "Item " + (i + 1);
          if (instance is IList list)
          {
            list.Add(elementInstance);
          }
        }
      }
      else
      {
        for (var i = 0; i < n; i++)
        {
          var elementInstance = Activator.CreateInstance(elementType);
          PopulateTestData(elementInstance!, i);
          if (instance is IList list)
          {
            list.Add(elementInstance);
          }
        }
      }
    }

  }

  /// <summary>
  /// Changes test data in the given instance.
  /// </summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="instance">The test data to modify.</param>
  public static void UpdateTestData<T>(T instance)
  {
    if (instance == null)
      throw new ArgumentNullException(nameof(instance));
    var properties = typeof(T).GetProperties().Where(prop => prop.CanWrite);
    foreach (var prop in properties)
    {
      var propType = prop.PropertyType.GetNotNullableType();
      // Update each property with new test data
      if (propType == typeof(string))
      {
        prop.SetValue(instance, prop.GetValue(instance) + " updated");
      }
      else if (propType == typeof(bool))
      {
        prop.SetValue(instance, Random.Shared.NextDouble() < 0.5);
      }
      else if (propType == typeof(Int32))
      {
        prop.SetValue(instance, Random.Shared.Next());
      }
      else if (propType == typeof(UInt32))
      {
        prop.SetValue(instance, (UInt32)Random.Shared.NextInt64(0, UInt32.MaxValue));
      }
      else if (propType == typeof(Int16))
      {
        prop.SetValue(instance, (Int16)(Random.Shared.Next(0, Int16.MaxValue)));
      }
      else if (propType == typeof(UInt16))
      {
        prop.SetValue(instance, (UInt16)(Random.Shared.Next(0, UInt16.MaxValue)));
      }
      else if (propType == typeof(Int64))
      {
        prop.SetValue(instance, Random.Shared.NextInt64());
      }
      else if (propType == typeof(UInt64))
      {
        prop.SetValue(instance, (UInt64)Random.Shared.NextInt64(0, (long)Int64.MaxValue));
      }
      else if (propType == typeof(HexInt))
      {
        prop.SetValue(instance, new HexInt(Random.Shared.Next()));
      }
      else if (propType == typeof(DateTime))
      {
        prop.SetValue(instance, DateTime.Now);
      }
      else if (propType.IsEnum)
      {
        var enumValues = Enum.GetValues(propType);
        var randomValue = enumValues.GetValue(Random.Shared.Next(enumValues.Length));
        prop.SetValue(instance, randomValue);
      }
      else if (propType == typeof(Guid))
      {
        prop.SetValue(instance, Guid.NewGuid());
      }
      else if (propType == typeof(Percent))
      {
        prop.SetValue(instance, new Percent(Random.Shared.NextDouble() * 100));
      }
      //else if (propType.IsClass && propType != typeof(string))
      //{
      //  // For complex types, recursively change their properties
      //  var nestedInstance = prop.GetValue(instance);
      //  if (nestedInstance == null)
      //  {
      //    nestedInstance = Activator.CreateInstance(propType);
      //    prop.SetValue(instance, nestedInstance);
      //  }
      //  UpdateTestData(nestedInstance);
      //}
      //else
      //{
      //  throw new NotSupportedException($"Property type {propType} is not supported for test data change.");
      //}
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
  /// Creates a new instance of HexBinary with a random byte array of the specified size.
  /// </summary>
  /// <param name="size"></param>
  /// <returns></returns>
  static HexBinary CreateHexBinary(int size)
  {
    size = size % 256; // Limit size to a reasonable range
    var bytes = new byte[size+1];
    for (int i = 0; i < size; i++)
    {
      bytes[i] = (byte)Random.Shared.Next(0, 256);
    }
    return new HexBinary(bytes);
  }

  static readonly Type[] VariantSupportedTypes =
  [
    typeof(string),
    typeof(int),
    typeof(bool),
    typeof(DateTime),
    //typeof(Guid),
    //typeof(Percent)
  ];
  /// <summary>
  /// Creates a new Variant instance containing a randomly generated value of the specified type.
  /// </summary>
  /// <remarks>The generated value is randomly selected based on the provided type. For enum types, a random
  /// value from the enumeration is chosen. For Percent, a random value between 0 and 100 is used.</remarks>
  /// <param name="type">The type of value to generate and encapsulate in the Variant. Supported types include string, int, bool, DateTime,
  /// enum types, Guid, and Percent.</param>
  /// <returns>A Variant containing a randomly generated value of the specified type.</returns>
  /// <exception cref="NotSupportedException">Thrown if the specified type is not supported for Variant creation.</exception>
  static Variant CreateVariant(Type type)
  {
    if (type == typeof(string))
      return new Variant("Sample string");
    else if (type == typeof(int))
      return new Variant(Random.Shared.Next());
    else if (type == typeof(bool))
      return new Variant(Random.Shared.NextDouble() < 0.5);
    else if (type == typeof(DateTime))
      return new Variant(DateTime.Now);
    else if (type.IsEnum)
    {
      var enumValues = Enum.GetValues(type);
      var randomValue = enumValues.GetValue(Random.Shared.Next(enumValues.Length));
      return new Variant(randomValue);
    }
    else if (type == typeof(Guid))
      return new Variant(Guid.NewGuid());
    else if (type == typeof(Percent))
      return new Variant(new Percent(Random.Shared.NextDouble() * 100));
    else
      throw new NotSupportedException($"Type {type} is not supported for creating a Variant.");
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


  /// <summary>
  /// Creates XML serializer overrides with separate XML namespaces for different DocumentModel namespaces.
  /// Also resolves closed generic AbstractColor type name collisions.
  /// </summary>
  /// <returns>Prepared overrides used by XmlSerializer.</returns>
  private static XmlAttributeOverrides CreateXmlSerializerOverrides(Assembly[] assemblies)
  {
    var overrides = new XmlAttributeOverrides();
    foreach (var assembly in assemblies)
    {


      foreach (var type in assembly.GetTypes()
                 .Where(t => t.Namespace?.StartsWith("DocumentModel", StringComparison.Ordinal) == true))
      {
        if (type.IsGenericTypeDefinition)
          continue;
        if (typeof(IXmlSerializable).IsAssignableFrom(type))
          continue;

        var xmlNamespace = GetXmlNamespaceForType(type);
        if (string.IsNullOrEmpty(xmlNamespace))
          continue;

        var attrs = new XmlAttributes
        {
          XmlType = new XmlTypeAttribute
          {
            Namespace = xmlNamespace
          }
        };

        if (type.IsGenericType)
        {
          var genericArgPart = string.Join("_", type.GetGenericArguments().Select(t => t.Name));
          attrs.XmlType.TypeName = $"{type.Name}_{genericArgPart}";
        }

        overrides.Add(type, attrs);
      }

      //AddAbstractColorOverride(overrides, typeof(DMD.AbstractColor<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>),
      //  "AbstractColorOfDrawingRgbColorModelHex", "urn:docmodel:drawings");
      //AddAbstractColorOverride(overrides,
      //  typeof(DMWD.WordAbstractColor<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>),
      //  "AbstractColorOfWord2010RgbColorModelHex", "urn:docmodel:wordprocessing-drawings");

    }
    return overrides;
  }

  /// <summary>
  /// Gets XML namespace for a model type based on its CLR namespace.
  /// </summary>
  /// <param name="type">Type for which XML namespace is generated.</param>
  /// <returns>XML namespace string.</returns>
  private static string GetXmlNamespaceForType(Type type)
  {
    var typeNamespace = type.Namespace ?? "DocumentModel";
    if (typeNamespace.StartsWith("DocumentModel.", StringComparison.Ordinal))
      return "urn:docmodel:" + typeNamespace.Substring("DocumentModel.".Length).ToLowerInvariant().Replace('.', ':');
    return "urn:docmodel:global";
  }

  /// <summary>
  /// Adds an XML type override for a closed generic AbstractColor{T}"/> type.
  /// </summary>
  /// <param name="overrides">Override collection to populate.</param>
  /// <param name="type">Closed generic abstract color type to override.</param>
  /// <param name="xmlTypeName">Unique XML type name.</param>
  /// <param name="xmlNamespace">XML namespace for the type.</param>
  private static void AddAbstractColorOverride(XmlAttributeOverrides overrides, Type type, string xmlTypeName, string xmlNamespace)
  {
    var attrs = new XmlAttributes
    {
      XmlType = new XmlTypeAttribute
      {
        TypeName = xmlTypeName,
        Namespace = xmlNamespace
      }
    };
    overrides.Add(type, attrs);
  }
}