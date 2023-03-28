namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the BookmarkElement Class converter from/to OpenXml.
///</summary>
public static class BookmarkEndConverter
{
  public static DMW.BookmarkEnd? CreateModelElement(DXW.BookmarkEnd? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.BookmarkEnd();
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.BookmarkEnd? openXmlElement, DMW.BookmarkEnd? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXW.BookmarkEnd CreateOpenXmlElement(DMW.BookmarkEnd value)
  {
    var openXmlElement = new DXW.BookmarkEnd();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXW.BookmarkEnd openXmlElement, DMW.BookmarkEnd value)
  {
    return true;
  }
}
