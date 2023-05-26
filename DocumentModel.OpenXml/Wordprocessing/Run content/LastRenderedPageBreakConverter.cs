using DocumentFormat.OpenXml;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// LastRenderedPageBreak class from/to OpenXml converter.
/// </summary>
public static class LastRenderedPageBreakConverter
{
  #region LastRenderedPageBreak model element conversion.
  public static DMW.LastRenderedPageBreak? CreateModelElement(DXW.LastRenderedPageBreak? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LastRenderedPageBreak();
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.LastRenderedPageBreak? openXmlElement, DMW.LastRenderedPageBreak? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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

  public static DXW.LastRenderedPageBreak CreateOpenXmlElement(DMW.LastRenderedPageBreak value)
  {
    var openXmlElement = new DXW.LastRenderedPageBreak();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }

  public static bool UpdateOpenXmlElement(DXW.LastRenderedPageBreak openXmlElement, DMW.LastRenderedPageBreak value)
  {
    return true;
  }
  #endregion
}
