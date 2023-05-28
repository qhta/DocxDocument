namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DataDisplayOptions16 Class.
/// </summary>
public static class DataDisplayOptions16Converter
{
  /// <summary>
  /// BooleanFalse.
  /// </summary>
  private static Boolean? GetBooleanFalse(DXDC.DataDisplayOptions16 openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO19DC.BooleanFalse>() != null;
  }
  
  private static bool CmpBooleanFalse(DXDC.DataDisplayOptions16 openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var val = openXmlElement.GetFirstChild<DXO19DC.BooleanFalse>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO19DC.BooleanFalse", val, value);
    return false;
  }
  
  private static void SetBooleanFalse(DXDC.DataDisplayOptions16 openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO19DC.BooleanFalse>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO19DC.BooleanFalse();
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Charts.DataDisplayOptions16? CreateModelElement(DXDC.DataDisplayOptions16? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Charts.DataDisplayOptions16();
      value.BooleanFalse = GetBooleanFalse(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDC.DataDisplayOptions16? openXmlElement, DMDC.DataDisplayOptions16? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpBooleanFalse(openXmlElement, value.BooleanFalse, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDC.DataDisplayOptions16 value)
    where OpenXmlElementType: DXDC.DataDisplayOptions16, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDC.DataDisplayOptions16 openXmlElement, DMDC.DataDisplayOptions16 value)
  {
    SetBooleanFalse(openXmlElement, value?.BooleanFalse);
  }
}
