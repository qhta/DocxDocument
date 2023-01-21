namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// List of Glossary Document Entries.
/// </summary>
public static class DocPartsConverter
{
  public static DMW.DocParts? CreateModelElement(DXW.DocParts? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.DocParts();
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.DocParts? value)
    where OpenXmlElementType: DXW.DocParts, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}
