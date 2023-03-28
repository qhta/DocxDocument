namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Vertical Positioning converter from/to OpenXml.
///</summary>
public static class VerticalPositionConverter
{
  /// <summary>
  /// Vertical Position Relative Base
  /// </summary>
  private static DMDrawsW.VerticalRelativePositionKind? GetRelativeFrom(DXDrawW.VerticalPosition openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DMDrawsW.VerticalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  private static bool CmpRelativeFrom(DXDrawW.VerticalPosition openXmlElement, DMDrawsW.VerticalRelativePositionKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DMDrawsW.VerticalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value, value, diffs, objName);
  }
  
  private static void SetRelativeFrom(DXDrawW.VerticalPosition openXmlElement, DMDrawsW.VerticalRelativePositionKind? value)
  {
    openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DMDrawsW.VerticalRelativePositionKind>(value);
  }
  
  /// <summary>
  /// Relative Vertical Alignment.
  /// </summary>
  private static String? GetVerticalAlignment(DXDrawW.VerticalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawW.VerticalAlignment>()?.Text;
  }
  
  private static bool CmpVerticalAlignment(DXDrawW.VerticalPosition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawW.VerticalAlignment>()?.Text == value;
  }
  
  private static void SetVerticalAlignment(DXDrawW.VerticalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawW.VerticalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawW.VerticalAlignment { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// PositionOffset.
  /// </summary>
  private static String? GetPositionOffset(DXDrawW.VerticalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDrawW.PositionOffset>()?.Text;
  }
  
  private static bool CmpPositionOffset(DXDrawW.VerticalPosition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawW.PositionOffset>()?.Text == value;
  }
  
  private static void SetPositionOffset(DXDrawW.VerticalPosition openXmlElement, String? value)
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
  /// PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  private static String? GetPercentagePositionVerticalOffset(DXDrawW.VerticalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2010WDraw.PercentagePositionVerticalOffset>()?.Text;
  }
  
  private static bool CmpPercentagePositionVerticalOffset(DXDrawW.VerticalPosition openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2010WDraw.PercentagePositionVerticalOffset>()?.Text == value;
  }
  
  private static void SetPercentagePositionVerticalOffset(DXDrawW.VerticalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010WDraw.PercentagePositionVerticalOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010WDraw.PercentagePositionVerticalOffset { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Wordprocessing.VerticalPosition? CreateModelElement(DXDrawW.VerticalPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Wordprocessing.VerticalPosition();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.VerticalAlignment = GetVerticalAlignment(openXmlElement);
      value.PositionOffset = GetPositionOffset(openXmlElement);
      value.PercentagePositionVerticalOffset = GetPercentagePositionVerticalOffset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawW.VerticalPosition? openXmlElement, DMDrawsW.VerticalPosition? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelativeFrom(openXmlElement, value.RelativeFrom, diffs, objName))
        ok = false;
      if (!CmpVerticalAlignment(openXmlElement, value.VerticalAlignment, diffs, objName))
        ok = false;
      if (!CmpPositionOffset(openXmlElement, value.PositionOffset, diffs, objName))
        ok = false;
      if (!CmpPercentagePositionVerticalOffset(openXmlElement, value.PercentagePositionVerticalOffset, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.VerticalPosition value)
    where OpenXmlElementType: DXDrawW.VerticalPosition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDrawW.VerticalPosition openXmlElement, DMDrawsW.VerticalPosition value)
  {
    SetRelativeFrom(openXmlElement, value?.RelativeFrom);
    SetVerticalAlignment(openXmlElement, value?.VerticalAlignment);
    SetPositionOffset(openXmlElement, value?.PositionOffset);
    SetPercentagePositionVerticalOffset(openXmlElement, value?.PercentagePositionVerticalOffset);
  }
}
