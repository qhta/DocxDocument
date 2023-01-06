namespace DocumentModel;

/// <summary>
/// Defines the Office Open XML file format version.
/// </summary>
public static class FileFormatVersionsConverter
{
  public static DocumentModel.FileFormatVersions? GetValue(DocumentFormat.OpenXml.FileFormatVersions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.FileFormatVersions();
      return value;
    }
    return null;
  }
  
  public static void SetValue(DocumentFormat.OpenXml.FileFormatVersions? openXmlElement, DocumentModel.FileFormatVersions? value)
  {
    if (openXmlElement != null)
    {
    }
  }
  
  public static DocumentFormat.OpenXml.FileFormatVersions? CreateOpenXmlElement(DocumentModel.FileFormatVersions? value)
  {
    if (value != null)
    {
      var openXmlElement = new DocumentFormat.OpenXml.FileFormatVersions();
      SetValue(openXmlElement, value);
      return openXmlElement;
    }
    return null;
  }
}
