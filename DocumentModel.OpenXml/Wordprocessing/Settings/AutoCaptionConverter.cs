namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Single Automatic Captioning Setting.
/// </summary>
public static class AutoCaptionConverter
{
  /// <summary>
  /// Identifier of Object to be Automatically Captioned
  /// </summary>
  private static String? GetName(DXW.AutoCaption openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXW.AutoCaption openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXW.AutoCaption openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Caption Used for Automatic Captioning
  /// </summary>
  private static String? GetCaption(DXW.AutoCaption openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Caption);
  }
  
  private static bool CmpCaption(DXW.AutoCaption openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Caption, value, diffs, objName, "Caption");
  }
  
  private static void SetCaption(DXW.AutoCaption openXmlElement, String? value)
  {
    openXmlElement.Caption = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMW.AutoCaption? CreateModelElement(DXW.AutoCaption? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.AutoCaption();
      value.Name = GetName(openXmlElement);
      value.Caption = GetCaption(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.AutoCaption? openXmlElement, DMW.AutoCaption? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpCaption(openXmlElement, value.Caption, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.AutoCaption value)
    where OpenXmlElementType: DXW.AutoCaption, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.AutoCaption openXmlElement, DMW.AutoCaption value)
  {
    SetName(openXmlElement, value?.Name);
    SetCaption(openXmlElement, value?.Caption);
  }
}
