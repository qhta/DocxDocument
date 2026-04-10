using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Tests reading document body from a sample file and serializing created DocumentModel elements.
/// </summary>
public class BodyReadTest : _AbstractTestClass
{
  private const string SampleFilePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\_Jakość oprogramowania2.zip";

  /// <summary>
  /// Runs all body read tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public static bool Run()
  {
    Console.WriteLine("=== Body Read Test ===\n");
    if (!TestReadBodyFromSampleFile()) return false;
    if (!TestCreateAndSerializeBodyElements()) return false;
    Console.WriteLine("All Body read tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests reading document body from the sample file and loading it into DocumentModel body.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  static bool TestReadBodyFromSampleFile()
  {
    Console.WriteLine("--- Read Body From Sample File ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }

    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(SampleFilePath, false);
    var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
    if (openXmlBody == null)
    {
      Console.WriteLine("✗ OpenXml body not found");
      return false;
    }

    var modelBody = new DocumentModel.Wordprocessing.Body();
    modelBody.LoadData(openXmlBody);

    var openXmlCount = openXmlBody.ChildElements.Count;
    var modelCount = modelBody.Count;

    Console.WriteLine($"OpenXml body elements count: {openXmlCount}");
    Console.WriteLine($"Model body elements count: {modelCount}");

    if (modelCount == 0)
    {
      Console.WriteLine("✗ Model body is empty after load");
      return false;
    }

    if (modelCount != openXmlCount)
    {
      Console.WriteLine($"✗ Body element count mismatch: model={modelCount}, openXml={openXmlCount}");
      return false;
    }

    var bodyXml = SerializeObjectToXml(modelBody);
    Console.WriteLine("Serialized Body XML:\n" + bodyXml);

    var bodyJson = JsonSerializer.Serialize(modelBody, JsonConfig.Options);
    Console.WriteLine("Serialized Body JSON:\n" + bodyJson);

    Console.WriteLine("✓ Body read from sample file test passed\n");
    return true;
  }

  /// <summary>
  /// Tests creation of DocumentModel body elements by reading from sample body and serializing each element.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  static bool TestCreateAndSerializeBodyElements()
  {
    Console.WriteLine("--- Create And Serialize DocumentModel Body Elements ---");

    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(SampleFilePath, false);
    var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
    if (openXmlBody == null)
    {
      Console.WriteLine("✗ OpenXml body not found");
      return false;
    }

    var modelBody = new DocumentModel.Wordprocessing.Body();
    modelBody.LoadData(openXmlBody);

    var createdElements = modelBody.Cast<ModelElement>().Take(10).ToList();
    if (createdElements.Count == 0)
    {
      Console.WriteLine("✗ No DocumentModel elements created from body");
      return false;
    }

    foreach (var element in createdElements)
    {
      var elementType = element.GetType();
      var elementXml = SerializeObjectToXml(element);
      var elementJson = JsonSerializer.Serialize(element, elementType, JsonConfig.Options);

      Console.WriteLine($"Element type: {elementType.FullName}");
      Console.WriteLine("XML:\n" + elementXml);
      Console.WriteLine("JSON:\n" + elementJson);

      var xmlDeserialized = DeserializeObjectFromXml(elementType, elementXml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine($"✗ XML deserialization returned null for '{elementType.Name}'");
        return false;
      }

      var jsonDeserialized = JsonSerializer.Deserialize(elementJson, elementType, JsonConfig.Options);
      if (jsonDeserialized == null)
      {
        Console.WriteLine($"✗ JSON deserialization returned null for '{elementType.Name}'");
        return false;
      }
    }

    Console.WriteLine("✓ Create and serialize DocumentModel elements test passed\n");
    return true;
  }

  /// <summary>
  /// Serializes an object to XML using its runtime type.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <returns>Serialized XML text.</returns>
  static string SerializeObjectToXml(object data)
  {
    var knownTypes = GetRuntimeKnownTypes(data, data.GetType());
    var xmlSerializer = CreateXmlSerializer(data.GetType(), knownTypes);
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, data);
      return stringWriter.ToString();
    }
  }

  /// <summary>
  /// Deserializes XML to an object of the specified type.
  /// </summary>
  /// <param name="dataType">Target type.</param>
  /// <param name="xml">XML input.</param>
  /// <returns>Deserialized instance or null.</returns>
  static object? DeserializeObjectFromXml(Type dataType, string xml)
  {
    var xmlSerializer = CreateXmlSerializer(dataType, []);
    using (var stringReader = new StringReader(xml))
    {
      return xmlSerializer.Deserialize(stringReader);
    }
  }

  /// <summary>
  /// Creates an XML serializer with type overrides to avoid generic XML type-name collisions.
  /// </summary>
  /// <param name="rootType">The root type to serialize.</param>
  /// <param name="knownTypes">An array of known types to include in the serializer.</param>
  /// <returns>An <see cref="XmlSerializer"/> configured for the requested type.</returns>
  static XmlSerializer CreateXmlSerializer(Type rootType, Type[] knownTypes)
  {
    var overrides = CreateXmlSerializerOverrides();
    return new XmlSerializer(rootType, overrides, knownTypes, null, null);
  }

  static Type[] GetRuntimeKnownTypes(object root, Type rootType)
  {
    var knownTypes = new HashSet<Type>();
    var visited = new HashSet<object>(ReferenceEqualityComparer.Instance);

    CollectRuntimeTypes(root, rootType, knownTypes, visited);

    return knownTypes.ToArray();
  }

  static void CollectRuntimeTypes(object? value, Type rootType, HashSet<Type> knownTypes, HashSet<object> visited)
  {
    if (value == null)
      return;

    if (!visited.Add(value))
      return;

    var type = value.GetType();

    if (type.Namespace?.StartsWith("DocumentModel", StringComparison.Ordinal) == true
        && type.IsPublic
        && !type.IsAbstract
        && !type.IsGenericTypeDefinition
        && type.BaseType != typeof(System.Attribute)
        && !type.IsSubclassOf(typeof(DocumentModel.ModelElementCollection<>))
        //&& !IsXmlAnonymousType(type) && (type.BaseType == null || !IsXmlAnonymousType(type.BaseType))
        && type != typeof(ExtensionList)
        && type != typeof(Body)
        && type != typeof(FooterReferences)
        && type != typeof(HeaderReferences)
        //&& type != typeof(Tabs)
        && type.GetCustomAttribute<XmlTypeAttribute>()?.AnonymousType != true)
    {
      knownTypes.Add(type);
    }

    if (value is IEnumerable enumerable && value is not string)
    {
      foreach (var item in enumerable)
        CollectRuntimeTypes(item, rootType, knownTypes, visited);
    }

    foreach (var prop in type.GetProperties(BindingFlags.Instance | BindingFlags.Public))
    {
      if (!prop.CanRead || prop.GetIndexParameters().Length > 0)
        continue;
      if (prop.PropertyType == typeof(string) || prop.PropertyType.IsValueType)
        continue;
      object? propValue;
      try
      {
        propValue = prop.GetValue(value);
      }
      catch
      {
        continue;
      }
      CollectRuntimeTypes(propValue, rootType, knownTypes, visited);
    }
  }

  public static bool IsXmlAnonymousType(Type type)
  {
    var xmlType = type.GetCustomAttribute<XmlTypeAttribute>();
    var xmlRoot = type.GetCustomAttribute<XmlRootAttribute>();

    return (xmlType?.AnonymousType ?? false)
           || (xmlRoot!=null);
  }

  /// <summary>
  /// Creates XML serializer overrides with separate XML namespaces for different DocumentModel namespaces.
  /// Also resolves closed generic AbstractColor type name collisions.
  /// </summary>
  /// <returns>Prepared overrides used by XmlSerializer.</returns>
  static XmlAttributeOverrides CreateXmlSerializerOverrides()
  {
    var overrides = new XmlAttributeOverrides();
    var assembly = typeof(DocumentModel.Wordprocessing.Body).Assembly;

    foreach (var type in assembly.GetTypes().Where(t => t.Namespace?.StartsWith("DocumentModel", StringComparison.Ordinal) == true))
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

    AddAbstractColorOverride(overrides,
      typeof(AbstractColor<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>),
      "AbstractColorOfDrawingRgbColorModelHex",
      "urn:docmodel:drawings");
    AddAbstractColorOverride(overrides,
      typeof(AbstractColor<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>),
      "AbstractColorOfWord2010RgbColorModelHex",
      "urn:docmodel:wordprocessing-drawings");

    return overrides;
  }

  /// <summary>
  /// Gets XML namespace for a model type based on its CLR namespace.
  /// </summary>
  /// <param name="type">Type for which XML namespace is generated.</param>
  /// <returns>XML namespace string.</returns>
  static string GetXmlNamespaceForType(Type type)
  {
    var typeNamespace = type.Namespace ?? "DocumentModel";
    if (typeNamespace.StartsWith("DocumentModel.", StringComparison.Ordinal))
      return "urn:docmodel:" + typeNamespace.Substring("DocumentModel.".Length).ToLowerInvariant().Replace('.', ':');
    return "urn:docmodel:global";
  }

  /// <summary>
  /// Adds an XML type override for a closed generic <see cref="AbstractColor{T}"/> type.
  /// </summary>
  /// <param name="overrides">Override collection to populate.</param>
  /// <param name="type">Closed generic abstract color type to override.</param>
  /// <param name="xmlTypeName">Unique XML type name.</param>
  static void AddAbstractColorOverride(XmlAttributeOverrides overrides, Type type, string xmlTypeName, string xmlNamespace)
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
