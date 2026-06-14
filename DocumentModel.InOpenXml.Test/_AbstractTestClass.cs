using System.Runtime.CompilerServices;

using DocumentFormat.OpenXml.Packaging;

using Qhta.OpenXmlTools;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Base class for all test classes, providing common functionality and constants.
/// </summary>
public abstract class _AbstractTestClass
{
  /// <summary>
  /// Common directory path used for testing purposes. This should be set to a valid directory on the test machine where sample files can be stored and accessed during tests.
  /// </summary>
  protected const string TestFileDir = @"d:\OneDrive\VS\Projects\DocxDocument\Samples\";

  /// <summary>
  /// Name of the test to display.
  /// </summary>
  protected string TestName => this.GetType().Name.ReplaceEnd("Test", "");

  /// <summary>
  /// Gets invoking method name using compiler services. 
  /// </summary>
  /// <param name="memberName">The name of the calling member. This is automatically provided by the compiler.</param>
  /// <returns>The name of the calling method.</returns>
  protected string GetInvokingMethodName([CallerMemberName] string memberName = "")
    => memberName;

  /// <summary>
  /// Runs a test and returns its result.
  /// </summary>
  /// <returns>True if test passed, false otherwise</returns>
  public abstract bool Run();

  /// <summary>
  /// Returns the XML representation of the given data object.
  /// This method uses the XmlSerializer to serialize the object to an XML string,
  /// which can be useful for debugging and comparing expected and actual results in tests.
  /// </summary>
  /// <param name="data">The object to serialize to XML.</param>
  /// <returns>The XML string representation of the object.</returns>
  protected string GetDataXml(object data)
  {
    var xmlSerializer = new XmlSerializer(data.GetType());
    string xmlString;
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, data);
      xmlString = stringWriter.ToString();
    }
    return xmlString;
  }

  /// <summary>
  /// Returns the XML content of the given OpenXmlPart as a formatted string with line numbers.
  /// </summary>
  /// <param name="part">The OpenXmlPart to retrieve the XML content from.</param>
  /// <returns>A string containing the formatted XML with line numbers if the part exists; otherwise, null.</returns>
  private string? GetPartXml(OpenXmlPart? part)
  {
    if (part != null)
    {
      using var stream = part.GetStream(FileMode.Open, FileAccess.Read);
      using var reader = new StreamReader(stream, System.Text.Encoding.UTF8);
      var xml = reader.ReadToEnd();
      var formattedXml = xml.FormatXmlWithLineNumbers();
      return formattedXml;
    }
    return null;
  }

  /// <summary>
  /// Serializes the specified object to its XML representation as a formatted string.
  /// </summary>
  /// <remarks>The returned XML is indented for readability. The object's type must be compatible with the
  /// XmlSerializer; otherwise, an exception may be thrown.</remarks>
  /// <param name="data">The object to serialize. The object must be serializable and not null.</param>
  /// <returns>A string containing the XML representation of the specified object.</returns>
  protected string SerializeToXml(object data)
  {
    return SerializeObjectToXml(data);
  }

  /// <summary>
  /// Deserializes the specified XML string into an object of the given type.
  /// </summary>
  /// <remarks>The XML string must match the structure expected by the XML serializer for the specified type. If
  /// the XML is invalid or does not match the expected format, the method may throw an exception.</remarks>
  /// <typeparam name="DataType">The type of the object to deserialize from the XML string. Must be compatible with XML serialization.</typeparam>
  /// <param name="xml">A string containing the XML data to deserialize. The XML must represent an object of type DataType.</param>
  /// <returns>An instance of type DataType deserialized from the XML string, or null if the XML does not represent a valid
  /// object.</returns>
  protected DataType? DeserializeFromXml<DataType>(string xml)
  {
    var xmlSerializer = new XmlSerializer(typeof(DataType));
    using (var stringReader = new StringReader(xml))
    {
      return (DataType?)xmlSerializer.Deserialize(stringReader);
    }
  }

  /// <summary>
  /// Serializes the specified object to a JSON string using indented formatting.
  /// </summary>
  /// <remarks>The resulting JSON string is formatted with indentation for readability. If the object contains
  /// properties that are not serializable, serialization may fail and throw an exception.</remarks>
  /// <param name="data">The object to serialize to JSON. Can be any serializable type.</param>
  /// <returns>A JSON-formatted string representation of the specified object.</returns>

  protected string SerializeToJson(object data)
  {
    return JsonSerializer.Serialize(data, CreateJsonSerializerOptions());
  }

  /// <summary>
  /// Deserializes the specified JSON string to an instance of the specified type.
  /// </summary>
  /// <remarks>The deserialization uses indented formatting options. If the JSON does not match the structure of
  /// the specified type, the method may throw a JsonException.</remarks>
  /// <typeparam name="DataType">The type of the object to deserialize to. Must be compatible with the structure of the JSON string.</typeparam>
  /// <param name="json">The JSON string to deserialize. Must represent a valid JSON object compatible with the specified type.</param>
  /// <returns>An instance of the specified type deserialized from the JSON string, or null if the input is null or empty.</returns>
  protected DataType? DeserializeFromJson<DataType>(string json)
  {
    return JsonSerializer.Deserialize<DataType>(json, CreateJsonSerializerOptions());
  }


  /// <summary>
  /// Deserializes the specified JSON string to an instance of the specified type.
  /// </summary>
  /// <remarks>The deserialization uses indented formatting options. If the JSON does not match the structure of
  /// the specified type, the method may throw a JsonException.</remarks>
  /// <param name="dataType">The type of the object to deserialize to. Must be compatible with the structure of the JSON string.</param>
  /// <param name="json">The JSON string to deserialize. Must represent a valid JSON object compatible with the specified type.</param>
  /// <returns>An instance of the specified type deserialized from the JSON string, or null if the input is null or empty.</returns>
  protected object? DeserializeFromJson(Type dataType, string json)
  {
    return JsonSerializer.Deserialize(json, dataType, CreateJsonSerializerOptions());
  }
  /// <summary>
  /// Retrieves the formatted XML content of the core properties part from a WordprocessingML document.
  /// </summary>
  /// <remarks>The method opens the file TestFileName in read-only mode and accesses its core properties part.
  /// The returned XML is formatted with line numbers for readability. If the document does not contain a core
  /// properties part, the method returns null.</remarks>
  /// <returns>A string containing the formatted XML with line numbers from the core properties part if it exists; otherwise,
  /// null.</returns>
  protected string? CorePropertiesPartXml(string testFileName)
  {
    using (var wordDoc = WordprocessingDocument.Open(testFileName, false))
    {
      return GetPartXml(wordDoc.CoreFilePropertiesPart);
    }
  }

  /// <summary>
  /// Retrieves the formatted XML content of the content properties part from a WordprocessingML document.
  /// </summary>
  /// <remarks>The method opens the file TestFileName in read-only mode and accesses its content properties part.
  /// The returned XML is formatted with line numbers for readability. If the document does not contain a content
  /// properties part, the method returns null.</remarks>
  /// <returns>A string containing the formatted XML with line numbers from the content properties part if it exists; otherwise,
  /// null.</returns>
  protected string? ExtendedFileProperties(string testFileName)
  {
    using (var wordDoc = WordprocessingDocument.Open(testFileName, false))
    {
      return GetPartXml(wordDoc.ExtendedFilePropertiesPart);
    }
  }


  /// <summary>
  /// Serializes an object to XML using its runtime type.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <returns>Serialized XML text.</returns>
  protected string SerializeObjectToXml(object data)
  {
    var xmlSerializer = CreateXmlSerializer(data, out var namespaces);
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, data, namespaces);
      return stringWriter.ToString();
    }
  }
 

  /// <summary>
  /// Deserializes XML to an object of the specified type.
  /// </summary>
  /// <param name="dataType">Target type.</param>
  /// <param name="xml">XML input.</param>
  /// <returns>Deserialized instance or null.</returns>
  protected object? DeserializeObjectFromXml(Type dataType, string xml)
  {
    var xmlSerializer = new XmlSerializer(dataType);
    using (var stringReader = new StringReader(xml))
    {
      return xmlSerializer.Deserialize(stringReader);
    }
  }

  /// <summary>
  /// Creates an XmlSerializer for the given data object, handling type overrides for generic ModelElement types.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <param name="namespaces">Output parameter for XML namespaces.</param>
  /// <returns>XmlSerializer instance.</returns>
  protected XmlSerializer CreateXmlSerializer(object data, out XmlSerializerNamespaces namespaces)
  => CreateXmlSerializer(data.GetType(), out namespaces);

  /// <summary>
  /// Creates an XmlSerializer for the specified root type, including overrides for generic ModelElement types to ensure unique XML type names.
  /// </summary>
  /// <param name="rootType">The root type for the XmlSerializer.</param>
  /// <param name="namespaces">Output parameter for XML namespaces.</param>
  /// <returns>XmlSerializer instance.</returns>
  protected XmlSerializer CreateXmlSerializer(Type rootType, out XmlSerializerNamespaces namespaces) 
  { 
    var UniqueTypeNames = new HashSet<string>();
    var overrides = new XmlAttributeOverrides();
    //var modelTypes = typeof(DMW.Document).Assembly.GetTypes()
    //  .Where(t => t.IsClass && !t.IsAbstract && !t.IsGenericType && !t.IsConstructedGenericType
    //            && !t.Implements(typeof(System.Collections.IDictionary))
    //  && t.GetConstructor([]) != null).ToArray();
    var modelTypes = new[] { typeof(DocumentModel.BuiltInProperty) };

    List<Type> visitedTypes = new List<Type>();
    foreach (var t in modelTypes)
    {
      //Debug.WriteLine($"GetXmlAttributeOverrides for {t.FullName}");
      GetXmlAttributeOverrides(t);
    }

    namespaces = new XmlSerializerNamespaces();
    namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
    namespaces.Add("d", "DocumentModel.Drawings");
    namespaces.Add("wd", "DocumentModel.Wordprocessing.Drawings");
    namespaces.Add("dw", "DocumentModel.Drawings.Wordprocessing");
    namespaces.Add("m", "DocumentModel.Math");

    var xmlSerializer = new XmlSerializer(rootType, overrides, modelTypes, null, null);
    return xmlSerializer;

    void GetXmlAttributeOverrides(Type? b)
    {
      if (b != null && b != typeof(object))
      {
        if (visitedTypes.Contains(b))
          return;
        visitedTypes.Add(b);
        if ((b.FullName ?? "").Contains("<>"))
          return;
        if (b.IsGenericType && b.GetGenericTypeDefinition() == typeof(DM.ModelElement<>))
        {
          var arg = b.GetGenericArguments()[0];
          if (arg.Name.Contains("<>"))
            return;
          if (!string.IsNullOrEmpty(arg.Namespace))
          {
            var unique = $"ModelElementOf_{arg.Namespace!.Replace('.', '_')}_{arg.Name}";
            if (UniqueTypeNames.Add(unique))
              overrides.Add(b, new XmlAttributes { XmlType = new XmlTypeAttribute(unique) });
          }
        }
        //Debug.WriteLine($"GetXmlAttributeOverrides2 for {b.BaseType?.FullName}");
        GetXmlAttributeOverrides(b.BaseType);
      }
    }
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

  /// <summary>
  /// Creates and configures JsonSerializerOptions for JSON serialization and deserialization.
  /// </summary>
  /// <returns></returns>
  protected JsonSerializerOptions CreateJsonSerializerOptions()
  {
    return JsonSerializationHelper.GetJsonSerializerOptions();

    //var options = new JsonSerializerOptions
    //{
    //  DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
    //  WriteIndented = true
    //};

    //return options;
  }

}