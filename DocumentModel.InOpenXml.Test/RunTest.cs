using System.Text.Json;
using System.Xml;
using System.Xml.Serialization;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Tests reading document Run from a sample file and serializing created DocumentModel elements.
/// </summary>
public class RunTest : _AbstractTestClass
{
  private const string SampleFilePath = @"D:\OneDrive\VS\Projects\DocxDocument\Samples\_Jakość oprogramowania2.zip";

  /// <summary>
  /// Runs all Run read tests.
  /// </summary>
  /// <returns>True if all tests pass; otherwise, false.</returns>
  public override bool Run()
  {
    Console.WriteLine("=== Run Read Test ===\n");
    //if (!TestReadOpenXmlRunFromSampleFile()) return false;
    if (!TestGetRunFromSampleFile()) return false;
    //if (!TestCreateAndSerializeRunElements()) return false;
    Console.WriteLine("All Run read tests passed.\n");
    return true;
  }

  /// <summary>
  /// Test reading OpenXml Run elements from the sample file and outputting their XML to the console and a file.
  /// </summary>
  /// <returns></returns>
  private bool TestReadOpenXmlRunFromSampleFile()
  {
    Console.WriteLine("--- Get Run From Sample File ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }

    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(SampleFilePath, false);
    var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
    if (openXmlBody == null)
    {
      Console.WriteLine("✗ OpenXml Body not found");
      return false;
    }

    var outputFileName = Path.Combine(Path.GetDirectoryName(SampleFilePath)!, "OpenXmlRunElements.xml");
    using TextWriter output = File.CreateText(outputFileName);
    output.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
    output.WriteLine("<Runs xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\">");
    foreach (var openXmlRun in openXmlBody.Descendants<DXW.Run>().ToArray())
    {
      var line = $"{openXmlRun.OuterXml.Replace(" xmlns:w=\"http://schemas.openxmlformats.org/wordprocessingml/2006/main\"", "")}";
      Console.WriteLine(line);
      output.WriteLine(line);
    }
    output.WriteLine("</Runs>");
    return true;
  }

  /// <summary>
  /// Test creating DocumentModel Run elements from OpenXml Run elements read from the sample file, serializing them to XML, and outputting to the console and a file.
  /// </summary>
  /// <returns></returns>
  private bool TestGetRunFromSampleFile()
  {
    Console.WriteLine("--- Get Run From Sample File ---");

    if (!File.Exists(SampleFilePath))
    {
      Console.WriteLine($"✗ Sample file not found: {SampleFilePath}");
      return false;
    }

    using var wordDoc = DocumentFormat.OpenXml.Packaging.WordprocessingDocument.Open(SampleFilePath, false);
    var openXmlBody = wordDoc.MainDocumentPart?.Document?.Body;
    if (openXmlBody == null)
    {
      Console.WriteLine("✗ OpenXml Body not found");
      return false;
    }

    var outputFileName = Path.Combine(Path.GetDirectoryName(SampleFilePath)!, "ModelRunElements.xml");
    using TextWriter output = File.CreateText(outputFileName);
    output.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
    output.WriteLine("<Runs xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\" xmlns=\"DocumentModel.Wordprocessing\">");
    foreach (var openXmlRun in openXmlBody.Descendants<DXW.Run>().ToArray())
    {
      var modelRun = new Run(openXmlRun);
      var modelRunXml = SerializeToXml(modelRun);
      var line = $"{modelRunXml.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n", "")
        .Replace(" xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\"","")
        .Replace(" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\"","")
        .Replace(" xmlns=\"DocumentModel.Wordprocessing\"","")}";
      Console.WriteLine(line);
      output.WriteLine(line);
    }
    output.WriteLine("</Runs>");
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
        && type != typeof(Run)
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
    var assembly = typeof(DocumentModel.Wordprocessing.Run).Assembly;

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
      typeof(DMD.AbstractColor<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>),
      "AbstractColorOfDrawingRgbColorModelHex",
      "urn:docmodel:drawings");
    AddAbstractColorOverride(overrides,
      typeof(DMWD.WordAbstractColor<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>),
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
