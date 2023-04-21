namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public static class HorizontalPositionConverter
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  private static DMDW.HorizontalRelativePositionKind? GetRelativeFrom(DXDW.HorizontalPosition openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DMDW.HorizontalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  private static bool CmpRelativeFrom(DXDW.HorizontalPosition openXmlElement, DMDW.HorizontalRelativePositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DMDW.HorizontalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value, value, diffs, objName);
  }
  
  private static void SetRelativeFrom(DXDW.HorizontalPosition openXmlElement, DMDW.HorizontalRelativePositionKind? value)
  {
    openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DMDW.HorizontalRelativePositionKind>(value);
  }
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  private static String? GetHorizontalAlignment(DXDW.HorizontalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDW.HorizontalAlignment>()?.Text;
  }
  
  private static bool CmpHorizontalAlignment(DXDW.HorizontalPosition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDW.HorizontalAlignment>()?.Text == value;
  }
  
  private static void SetHorizontalAlignment(DXDW.HorizontalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.HorizontalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDW.HorizontalAlignment { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  private static String? GetPositionOffset(DXDW.HorizontalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDW.PositionOffset>()?.Text;
  }
  
  private static bool CmpPositionOffset(DXDW.HorizontalPosition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDW.PositionOffset>()?.Text == value;
  }
  
  private static void SetPositionOffset(DXDW.HorizontalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.PositionOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDW.PositionOffset { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  private static String? GetPercentagePositionHeightOffset(DXDW.HorizontalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO10WD.PercentagePositionHeightOffset>()?.Text;
  }
  
  private static bool CmpPercentagePositionHeightOffset(DXDW.HorizontalPosition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO10WD.PercentagePositionHeightOffset>()?.Text == value;
  }
  
  private static void SetPercentagePositionHeightOffset(DXDW.HorizontalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10WD.PercentagePositionHeightOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO10WD.PercentagePositionHeightOffset { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.HorizontalPosition? CreateModelElement(DXDW.HorizontalPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.HorizontalPosition();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.HorizontalAlignment = GetHorizontalAlignment(openXmlElement);
      value.PositionOffset = GetPositionOffset(openXmlElement);
      value.PercentagePositionHeightOffset = GetPercentagePositionHeightOffset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDW.HorizontalPosition? openXmlElement, DMDW.HorizontalPosition? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelativeFrom(openXmlElement, value.RelativeFrom, diffs, objName))
        ok = false;
      if (!CmpHorizontalAlignment(openXmlElement, value.HorizontalAlignment, diffs, objName))
        ok = false;
      if (!CmpPositionOffset(openXmlElement, value.PositionOffset, diffs, objName))
        ok = false;
      if (!CmpPercentagePositionHeightOffset(openXmlElement, value.PercentagePositionHeightOffset, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.HorizontalPosition value)
    where OpenXmlElementType: DXDW.HorizontalPosition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.HorizontalPosition openXmlElement, DMDW.HorizontalPosition value)
  {
    SetRelativeFrom(openXmlElement, value?.RelativeFrom);
    SetHorizontalAlignment(openXmlElement, value?.HorizontalAlignment);
    SetPositionOffset(openXmlElement, value?.PositionOffset);
    SetPercentagePositionHeightOffset(openXmlElement, value?.PercentagePositionHeightOffset);
  }
}
