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
}