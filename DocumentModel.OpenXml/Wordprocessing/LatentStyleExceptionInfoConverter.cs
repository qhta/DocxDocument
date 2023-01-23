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
    return openXmlElement?.Name?.Value;
  }
  
  private static bool CmpName(DXW.LatentStyleExceptionInfo openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Name?.Value == value;
  }
  
  private static void SetName(DXW.LatentStyleExceptionInfo openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Name = new StringValue { Value = value };
    else
      openXmlElement.Name = null;
  }
  
  /// <summary>
  /// Latent Style Locking Setting
  /// </summary>
  private static Boolean? GetLocked(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement?.Locked?.Value;
  }
  
  private static bool CmpLocked(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.Locked?.Value == value;
  }
  
  private static void SetLocked(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Locked = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Locked = null;
  }
  
  /// <summary>
  /// Override default sorting order
  /// </summary>
  private static Int32? GetUiPriority(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement.UiPriority?.Value;
  }
  
  private static bool CmpUiPriority(DXW.LatentStyleExceptionInfo openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.UiPriority?.Value == value;
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
    return openXmlElement?.SemiHidden?.Value;
  }
  
  private static bool CmpSemiHidden(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.SemiHidden?.Value == value;
  }
  
  private static void SetSemiHidden(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.SemiHidden = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.SemiHidden = null;
  }
  
  /// <summary>
  /// Unhide when used
  /// </summary>
  private static Boolean? GetUnhideWhenUsed(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement?.UnhideWhenUsed?.Value;
  }
  
  private static bool CmpUnhideWhenUsed(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.UnhideWhenUsed?.Value == value;
  }
  
  private static void SetUnhideWhenUsed(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.UnhideWhenUsed = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.UnhideWhenUsed = null;
  }
  
  /// <summary>
  /// Latent Style Primary Style Setting
  /// </summary>
  private static Boolean? GetPrimaryStyle(DXW.LatentStyleExceptionInfo openXmlElement)
  {
    return openXmlElement?.PrimaryStyle?.Value;
  }
  
  private static bool CmpPrimaryStyle(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    return openXmlElement?.PrimaryStyle?.Value == value;
  }
  
  private static void SetPrimaryStyle(DXW.LatentStyleExceptionInfo openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.PrimaryStyle = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.PrimaryStyle = null;
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
  
  public static bool CompareModelElement(DXW.LatentStyleExceptionInfo? openXmlElement, DMW.LatentStyleExceptionInfo? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpName(openXmlElement, value.Name, diffs, objName))
        ok = false;
      if (!CmpLocked(openXmlElement, value.Locked, diffs, objName))
        ok = false;
      if (!CmpUiPriority(openXmlElement, value.UiPriority, diffs, objName))
        ok = false;
      if (!CmpSemiHidden(openXmlElement, value.SemiHidden, diffs, objName))
        ok = false;
      if (!CmpUnhideWhenUsed(openXmlElement, value.UnhideWhenUsed, diffs, objName))
        ok = false;
      if (!CmpPrimaryStyle(openXmlElement, value.PrimaryStyle, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.LatentStyleExceptionInfo? value)
    where OpenXmlElementType: DXW.LatentStyleExceptionInfo, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetName(openXmlElement, value?.Name);
      SetLocked(openXmlElement, value?.Locked);
      SetUiPriority(openXmlElement, value?.UiPriority);
      SetSemiHidden(openXmlElement, value?.SemiHidden);
      SetUnhideWhenUsed(openXmlElement, value?.UnhideWhenUsed);
      SetPrimaryStyle(openXmlElement, value?.PrimaryStyle);
      return openXmlElement;
    }
    return default;
  }
}
