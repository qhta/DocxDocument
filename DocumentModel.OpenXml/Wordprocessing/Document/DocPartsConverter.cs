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
  
  public static bool CompareModelElement(DXW.DocParts? openXmlElement, DMW.DocParts? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.DocParts value)
    where OpenXmlElementType: DXW.DocParts, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.DocParts openXmlElement, DMW.DocParts value)
  {
  }
}
