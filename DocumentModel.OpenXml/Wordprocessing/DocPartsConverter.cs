using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   List of Glossary Document Entries.
/// </summary>
public static class DocPartsConverter
{
  public static DocParts? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.DocParts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocParts();
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocParts? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Wordprocessing.DocParts, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}