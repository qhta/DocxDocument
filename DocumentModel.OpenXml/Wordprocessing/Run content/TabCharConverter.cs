namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// <see cref="DMW.CarriageReturn"/> class from/to OpenXml converter.
/// </summary>
public static class TabCharConverter
{
  public static DMW.TabChar? CreateModelElement(DXW.TabChar? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.TabChar();
      return value;
    }
    return null;
  }

  public static bool CompareModelElement(DXW.TabChar? openXmlElement, DMW.TabChar? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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

  public static DX.OpenXmlElement CreateOpenXmlElement(DMW.TabChar value)
  {
     return new DXW.TabChar();
  }

  public static bool UpdateOpenXmlElement(DXW.TabChar? openXmlElement, DMW.TabChar? value)
    => true;


}
