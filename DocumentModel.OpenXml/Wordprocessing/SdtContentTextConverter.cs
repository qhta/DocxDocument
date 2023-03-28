namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentText Class.
/// </summary>
public static class SdtContentTextConverter
{
  /// <summary>
  /// Allow Soft Line Breaks
  /// </summary>
  private static Boolean? GetMultiLine(DXW.SdtContentText openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.MultiLine);
  }
  
  private static bool CmpMultiLine(DXW.SdtContentText openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.MultiLine, value, diffs, objName, "MultiLine");
  }
  
  private static void SetMultiLine(DXW.SdtContentText openXmlElement, Boolean? value)
  {
    openXmlElement.MultiLine = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.SdtContentText? CreateModelElement(DXW.SdtContentText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.SdtContentText();
      value.MultiLine = GetMultiLine(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.SdtContentText? openXmlElement, DMW.SdtContentText? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpMultiLine(openXmlElement, value.MultiLine, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentText value)
    where OpenXmlElementType: DXW.SdtContentText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.SdtContentText openXmlElement, DMW.SdtContentText value)
  {
    SetMultiLine(openXmlElement, value?.MultiLine);
  }
}
