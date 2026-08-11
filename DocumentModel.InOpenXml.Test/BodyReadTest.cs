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
  public override bool Run()
  {
    Console.WriteLine("=== Body Read Test ===\n");
    if (!TestReadBodyFromSampleFile()) return false;
    //if (!TestCreateAndSerializeBodyElements()) return false;
    Console.WriteLine("All Body read tests passed.\n");
    return true;
  }

  /// <summary>
  /// Tests reading document body from the sample file and loading it into DocumentModel body.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestReadBodyFromSampleFile()
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

    var t0 = DateTime.Now;
    Body modelBody = new DocumentModel.Wordprocessing.Body(openXmlBody);
    var t1 = DateTime.Now;
    Debug.WriteLine($"LoadData duration: {(t1 - t0).TotalMilliseconds} ms");
    var openXmlCount = openXmlBody.ChildElements.Count;
    var modelCount = modelBody.Items.Count;
    var t2 = DateTime.Now;
    Debug.WriteLine($"Count retrieval duration: {(t2 - t1).TotalMilliseconds} ms");
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
    //var t3 = DateTime.Now;
    //var bodyXml = SerializeObjectToXml(modelBody);
    //var t4 = DateTime.Now;
    //Debug.WriteLine($"Serialization duration: {(t4 - t3).TotalMilliseconds} ms");
    //Console.WriteLine("Serialized Body XML:\n" + bodyXml);

    //var t3 = DateTime.Now;
    //var bodyXml = SerializeObjectToXml(modelBody);
    //var t4 = DateTime.Now;
    //Debug.WriteLine($"Serialization duration: {(t4 - t3).TotalMilliseconds} ms");
    //Console.WriteLine("Serialized Body XML:\n" + bodyXml);

    Console.WriteLine("✓ Body read from sample file test passed\n");
    return true;
  }

  /// <summary>
  /// Tests creation of DocumentModel body elements by reading from sample body and serializing each element.
  /// </summary>
  /// <returns>True if the test passes; otherwise, false.</returns>
  private bool TestCreateAndSerializeBodyElements()
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

    var createdElements = modelBody.Items.Cast<ModelElement>().Take(10).ToList();
    if (createdElements.Count == 0)
    {
      Console.WriteLine("✗ No DocumentModel elements created from body");
      return false;
    }

    foreach (var element in createdElements)
    {
      var elementType = element.GetType();
      var elementXml = SerializeObjectToXml(element);
      //var elementJson = JsonSerializer.Serialize(element, elementType, JsonConfig.Options);

      Console.WriteLine($"Element type: {elementType.FullName}");
      Console.WriteLine("XML:\n" + elementXml);
      //Console.WriteLine("JSON:\n" + elementJson);
      var xmlDeserialized = DeserializeObjectFromXml(elementType, elementXml);
      if (xmlDeserialized == null)
      {
        Console.WriteLine($"✗ XML deserialization returned null for '{elementType.Name}'");
        return false;
      }

      //var jsonDeserialized = JsonSerializer.Deserialize(elementJson, elementType, JsonConfig.Options);
      //if (jsonDeserialized == null)
      //{
      //  Console.WriteLine($"✗ JSON deserialization returned null for '{elementType.Name}'");
      //  return false;
      //}
    }

    Console.WriteLine("✓ Create and serialize DocumentModel elements test passed\n");
    return true;
  }


  private Type[] GetRuntimeKnownTypes(object root, Type rootType)
  {
    var knownTypes = new HashSet<Type>();
    var visited = new HashSet<object>(ReferenceEqualityComparer.Instance);

    CollectRuntimeTypes(root, rootType, knownTypes, visited);

    return knownTypes.ToArray();
  }

  private void CollectRuntimeTypes(object? value, Type rootType, HashSet<Type> knownTypes, HashSet<object> visited)
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

  private bool IsXmlAnonymousType(Type type)
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
  private XmlAttributeOverrides CreateXmlSerializerOverrides()
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
      typeof(DM.AnyColor<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>),
      "AbstractColorOfDrawingRgbColorModelHex",
      "urn:docmodel:drawings");
    AddAbstractColorOverride(overrides,
      typeof(DM.AnyColor<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>),
      "AbstractColorOfWord2010RgbColorModelHex",
      "urn:docmodel:wordprocessing-drawings");

    return overrides;
  }

  /// <summary>
  /// Gets XML namespace for a model type based on its CLR namespace.
  /// </summary>
  /// <param name="type">Type for which XML namespace is generated.</param>
  /// <returns>XML namespace string.</returns>
  private string GetXmlNamespaceForType(Type type)
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
  private void AddAbstractColorOverride(XmlAttributeOverrides overrides, Type type, string xmlTypeName, string xmlNamespace)
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
