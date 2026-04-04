using DocumentFormat.OpenXml.Packaging;

namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Base class for all test classes, providing common functionality and constants.
/// </summary>
public class AbstractTestClass
{
  /// <summary>
  /// Common file name used for testing purposes. This file is created and deleted during tests, so it should not exist before the tests are run.
  /// </summary>
  protected const string TestFileName = "temp.docx";

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
}