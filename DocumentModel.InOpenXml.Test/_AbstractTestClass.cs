using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Base class for all test classes, providing common functionality and constants.
/// </summary>
public class _AbstractTestClass
{
  /// <summary>
  /// Common file name used for testing purposes. This file is created and deleted during tests, so it should not exist before the tests are run.
  /// </summary>
  protected const string TestFileName = "temp.docx";
  /// <summary>
  /// Common directory path used for testing purposes. This should be set to a valid directory on the test machine where sample files can be stored and accessed during tests.
  /// </summary>
  protected const string TestFileDir = @"d:\OneDrive\VS\Projects\DocxDocument\Samples\";

  /// <summary>
  /// Returns the XML representation of the given data object.
  /// This method uses the XmlSerializer to serialize the object to an XML string,
  /// which can be useful for debugging and comparing expected and actual results in tests.
  /// </summary>
  /// <param name="data">The object to serialize to XML.</param>
  /// <returns>The XML string representation of the object.</returns>
  protected static string GetDataXml(object data)
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
  public static string? GetPartXml(OpenXmlPart? part)
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
  protected static string SerializeToXml(object data)
  {
    var xmlSerializer = new XmlSerializer(data.GetType());
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, data);
      return stringWriter.ToString();
    }
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
  protected static DataType? DeserializeFromXml<DataType>(string xml)
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
  protected static string SerializeToJson(object data)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Serialize(data, jsonOptions);
  }

  /// <summary>
  /// Deserializes the specified JSON string to an instance of the specified type.
  /// </summary>
  /// <remarks>The deserialization uses indented formatting options. If the JSON does not match the structure of
  /// the specified type, the method may throw a JsonException.</remarks>
  /// <typeparam name="DataType">The type of the object to deserialize to. Must be compatible with the structure of the JSON string.</typeparam>
  /// <param name="json">The JSON string to deserialize. Must represent a valid JSON object compatible with the specified type.</param>
  /// <returns>An instance of the specified type deserialized from the JSON string, or null if the input is null or empty.</returns>
  protected static DataType? DeserializeFromJson<DataType>(string json)
  {
    var jsonOptions = new JsonSerializerOptions { WriteIndented = true };
    return JsonSerializer.Deserialize<DataType>(json, jsonOptions);
  }


  /// <summary>
  /// Retrieves the formatted XML content of the core properties part from a WordprocessingML document.
  /// </summary>
  /// <remarks>The method opens the file TestFileName in read-only mode and accesses its core properties part.
  /// The returned XML is formatted with line numbers for readability. If the document does not contain a core
  /// properties part, the method returns null.</remarks>
  /// <returns>A string containing the formatted XML with line numbers from the core properties part if it exists; otherwise,
  /// null.</returns>
  public static string? CorePropertiesPartXml()
  {
    using (var wordDoc = WordprocessingDocument.Open(TestFileName, false))
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
  public static string? ExtendedFileProperties()
  {
    using (var wordDoc = WordprocessingDocument.Open(TestFileName, false))
    {
      return GetPartXml(wordDoc.ExtendedFilePropertiesPart);
    }
  }


  /// <summary>
  /// Serializes an object to XML using its runtime type.
  /// </summary>
  /// <param name="data">The object to serialize.</param>
  /// <returns>Serialized XML text.</returns>
  public static string SerializeObjectToXml(object data)
  {
    var rootType = data.GetType();
    var UniqueTypeNames = new HashSet<string>();
    var overrides = new XmlAttributeOverrides();
    var modelTypes = typeof(DMW.Document).Assembly.GetTypes()
      .Where(t => typeof(DM.ModelElement).IsAssignableFrom(t) && !t.IsAbstract);

    foreach (var t in modelTypes)
    {
      var b = t.BaseType;
      while (b != null)
      {
        if (b.IsGenericType && b.GetGenericTypeDefinition() == typeof(DM.ModelElement<>))
        {
          var arg = b.GetGenericArguments()[0];
          if (!string.IsNullOrEmpty(arg.Namespace))
          {
            var unique = $"ModelElementOf_{arg.Namespace!.Replace('.', '_')}_{arg.Name}";
            if (UniqueTypeNames.Add(unique))
              overrides.Add(b, new XmlAttributes { XmlType = new XmlTypeAttribute(unique) });
          }
          break;
        }
        b = b.BaseType;
      }
    }

    var ns = new XmlSerializerNamespaces();
    ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
    ns.Add("d", "DocumentModel.Drawings");
    ns.Add("wd", "DocumentModel.Wordprocessing.Drawings");
    ns.Add("dw", "DocumentModel.Drawings.Wordprocessing");
    ns.Add("m", "DocumentModel.Math");

    //Type[] knownTypes = typeof(DMW.Document).Assembly.GetTypes().Where
    //  (t => 
    //    t.IsAssignableTo(typeof(DM.ModelElement)) && t.IsPublic && !t.IsAbstract && !t.IsGenericType 
    //    && t.GetCustomAttribute<SpecificClassAttribute>() != null
    //    ).ToArray();

    var xmlSerializer = new XmlSerializer(rootType, overrides);
    using (var stringWriter = new StringWriter())
    using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
    {
      xmlSerializer.Serialize(xmlWriter, data, ns);
      return stringWriter.ToString();
    }
  }

  /// <summary>
  /// Deserializes XML to an object of the specified type.
  /// </summary>
  /// <param name="dataType">Target type.</param>
  /// <param name="xml">XML input.</param>
  /// <returns>Deserialized instance or null.</returns>
  public static object? DeserializeObjectFromXml(Type dataType, string xml)
  {
    var xmlSerializer = new XmlSerializer(dataType);
    using (var stringReader = new StringReader(xml))
    {
      return xmlSerializer.Deserialize(stringReader);
    }
  }
}