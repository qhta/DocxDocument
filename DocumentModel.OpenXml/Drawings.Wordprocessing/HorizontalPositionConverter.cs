namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Horizontal Positioning.
/// </summary>
public static class HorizontalPositionConverter
{
  /// <summary>
  /// Horizontal Position Relative Base
  /// </summary>
  private static DMDrawsW.HorizontalRelativePositionKind? GetRelativeFrom(DXDrawW.HorizontalPosition openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DMDrawsW.HorizontalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  private static bool CmpRelativeFrom(DXDrawW.HorizontalPosition openXmlElement, DMDrawsW.HorizontalRelativePositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DMDrawsW.HorizontalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetRelativeFrom(DXDrawW.HorizontalPosition openXmlElement, DMDrawsW.HorizontalRelativePositionKind? value)
  {
    openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DMDrawsW.HorizontalRelativePositionKind>(value);
  }
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  private static String? GetHorizontalAlignment(DXDrawW.HorizontalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawW.HorizontalAlignment>()?.Text;
  }
  
  private static bool CmpHorizontalAlignment(DXDrawW.HorizontalPosition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawW.HorizontalAlignment>()?.Text == value;
  }
  
  private static void SetHorizontalAlignment(DXDrawW.HorizontalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.HorizontalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawW.HorizontalAlignment { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Absolute Position Offset.
  /// </summary>
  private static String? GetPositionOffset(DXDrawW.HorizontalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawW.PositionOffset>()?.Text;
  }
  
  private static bool CmpPositionOffset(DXDrawW.HorizontalPosition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawW.PositionOffset>()?.Text == value;
  }
  
  private static void SetPositionOffset(DXDrawW.HorizontalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.PositionOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawW.PositionOffset { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PercentagePositionHeightOffset, this property is only available in Office 2010 and later..
  /// </summary>
  private static String? GetPercentagePositionHeightOffset(DXDrawW.HorizontalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2010WDraw.PercentagePositionHeightOffset>()?.Text;
  }
  
  private static bool CmpPercentagePositionHeightOffset(DXDrawW.HorizontalPosition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2010WDraw.PercentagePositionHeightOffset>()?.Text == value;
  }
  
  private static void SetPercentagePositionHeightOffset(DXDrawW.HorizontalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010WDraw.PercentagePositionHeightOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010WDraw.PercentagePositionHeightOffset { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.HorizontalPosition? CreateModelElement(DXDrawW.HorizontalPosition? openXmlElement)
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
  
  public static bool CompareModelElement(DXDrawW.HorizontalPosition? openXmlElement, DMDrawsW.HorizontalPosition? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.HorizontalPosition value)
    where OpenXmlElementType: DXDrawW.HorizontalPosition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawW.HorizontalPosition openXmlElement, DMDrawsW.HorizontalPosition value)
  {
    SetRelativeFrom(openXmlElement, value?.RelativeFrom);
    SetHorizontalAlignment(openXmlElement, value?.HorizontalAlignment);
    SetPositionOffset(openXmlElement, value?.PositionOffset);
    SetPercentagePositionHeightOffset(openXmlElement, value?.PercentagePositionHeightOffset);
    }
  }
