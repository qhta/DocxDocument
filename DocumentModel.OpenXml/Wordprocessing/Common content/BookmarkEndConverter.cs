namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.BookmarkEnd"/> class from/to OpenXml converter.
/// </summary>
public static class BookmarkEndConverter
{
  public static DMW.BookmarkEnd? CreateModelElement(DXW.BookmarkEnd? openXmlElement)
    => MarkupRangeElementConverter.CreateModelElement<DMW.BookmarkEnd>(openXmlElement);
  
  public static bool CompareModelElement(DXW.BookmarkEnd? openXmlElement, DMW.BookmarkEnd? value, DiffList? diffs = null, string? objName = null, string? propName = null)
    => MarkupRangeElementConverter.CompareModelElement(openXmlElement, value, diffs, objName, propName);
  
  public static DXW.BookmarkEnd CreateOpenXmlElement(DMW.BookmarkEnd value)
    => MarkupRangeElementConverter.CreateOpenXmlElement<DXW.BookmarkEnd>(value);
  public static bool UpdateOpenXmlElement(DXW.BookmarkEnd openXmlElement, DMW.BookmarkEnd value)
    => true;
}
