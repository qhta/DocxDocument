namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Latent Style Exception.
/// </summary>
public static class LatentStyleExceptionInfoConverter
{
  /// <summary>
  /// Primary Style Name
  /// </summary>
  private static String? GetName(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Name);
  }
  
  private static bool CmpName(DXW.LatentStyleExceptionInfo openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Name, value, diffs, objName, "Name");
  }
  
  private static void SetName(DXW.LatentStyleExceptionInfo openXmlElement, String? value)
  {
    openXmlElement.Name = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Latent Style Locking Setting
  /// </summary>
  private static Boolean? GetLocked(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.Locked);
  }
  
  private static bool CmpLocked(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.Locked, value, diffs, objName, "Locked");
  }
  
  private static void SetLocked(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    openXmlElement.Locked = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Override default sorting order
  /// </summary>
  private static Int32? GetUiPriority(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement?.UiPriority?.Value;
  }
  
  private static bool CmpUiPriority(DXW.LatentStyleExceptionInfo openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.UiPriority?.Value == value) return true;
    diffs?.Add(objName, "UiPriority", openXmlElement?.UiPriority?.Value, value);
    return false;
  }
  
  private static void SetUiPriority(DXW.LatentStyleExceptionInfo openXmlElement, Int32? value)
  {
    openXmlElement.UiPriority = value;
  }
  
  /// <summary>
  /// Semi hidden text override
  /// </summary>
  private static Boolean? GetSemiHidden(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.SemiHidden);
  }
  
  private static bool CmpSemiHidden(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.SemiHidden, value, diffs, objName, "SemiHidden");
  }
  
  private static void SetSemiHidden(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    openXmlElement.SemiHidden = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Unhide when used
  /// </summary>
  private static Boolean? GetUnhideWhenUsed(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.UnhideWhenUsed);
  }
  
  private static bool CmpUnhideWhenUsed(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.UnhideWhenUsed, value, diffs, objName, "UnhideWhenUsed");
  }
  
  private static void SetUnhideWhenUsed(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    openXmlElement.UnhideWhenUsed = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  /// <summary>
  /// Latent Style Primary Style Setting
  /// </summary>
  private static Boolean? GetPrimaryStyle(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.PrimaryStyle);
  }
  
  private static bool CmpPrimaryStyle(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return BooleanValueConverter.CmpValue(openXmlElement?.PrimaryStyle, value, diffs, objName, "PrimaryStyle");
  }
  
  private static void SetPrimaryStyle(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    openXmlElement.PrimaryStyle = BooleanValueConverter.CreateOnOffValue(value);
  }
  
  public static DMW.LatentStyleExceptionInfo? CreateModelElement(DXW.LatentStyleExceptionInfo? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.LatentStyleExceptionInfo();
      value.Name = GetName(openXmlElement);
      value.Locked = GetLocked(openXmlElement);
      value.UiPriority = GetUiPriority(openXmlElement);
      value.SemiHidden = GetSemiHidden(openXmlElement);
      value.UnhideWhenUsed = GetUnhideWhenUsed(openXmlElement);
      value.PrimaryStyle = GetPrimaryStyle(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXW.LatentStyleExceptionInfo? openXmlElement, DMW.LatentStyleExceptionInfo? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName, propName))
        ok = false;
      if (!CmpLocked(openXmlElement, value.Locked, diffs, objName, propName))
        ok = false;
      if (!CmpUiPriority(openXmlElement, value.UiPriority, diffs, objName, propName))
        ok = false;
      if (!CmpSemiHidden(openXmlElement, value.SemiHidden, diffs, objName, propName))
        ok = false;
      if (!CmpUnhideWhenUsed(openXmlElement, value.UnhideWhenUsed, diffs, objName, propName))
        ok = false;
      if (!CmpPrimaryStyle(openXmlElement, value.PrimaryStyle, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.LatentStyleExceptionInfo value)
    where OpenXmlElementType: DXW.LatentStyleExceptionInfo, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXW.LatentStyleExceptionInfo openXmlElement, DMW.LatentStyleExceptionInfo value)
  {
    SetName(openXmlElement, value?.Name);
    SetLocked(openXmlElement, value?.Locked);
    SetUiPriority(openXmlElement, value?.UiPriority);
    SetSemiHidden(openXmlElement, value?.SemiHidden);
    SetUnhideWhenUsed(openXmlElement, value?.UnhideWhenUsed);
    SetPrimaryStyle(openXmlElement, value?.PrimaryStyle);
  }
}
