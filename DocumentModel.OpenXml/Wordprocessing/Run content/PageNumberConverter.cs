namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.PageNumber"/> class from/to OpenXml converter.
/// </summary>
public static class PageNumberConverter
{
  public static DMW.PageNumber? CreateModelElement(DXW.PageNumber? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.PageNumber();
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.PageNumber? openXmlElement, DMW.PageNumber? value, DiffList? diffs, string? objName)
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

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.PageNumber value)
  {
    return new DXW.PageNumber();
  }

  public static bool UpdateOpenXmlElement(DXW.PageNumber? openXmlElement, DMW.PageNumber? value)
    => true;

}
