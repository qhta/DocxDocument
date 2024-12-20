namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Vertical Positioning.
/// </summary>
public static class VerticalPositionConverter
{
  /// <summary>
  /// Vertical Position Relative Base
  /// </summary>
  private static DMDW.VerticalRelativePositionKind? GetRelativeFrom(DXDW.VerticalPosition openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DMDW.VerticalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  private static bool CmpRelativeFrom(DXDW.VerticalPosition openXmlElement, DMDW.VerticalRelativePositionKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DMDW.VerticalRelativePositionKind>(openXmlElement?.RelativeFrom?.Value, value, diffs, objName, propName);
  }
  
  private static void SetRelativeFrom(DXDW.VerticalPosition openXmlElement, DMDW.VerticalRelativePositionKind? value)
  {
    openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.VerticalRelativePositionValues, DMDW.VerticalRelativePositionKind>(value);
  }
  
  /// <summary>
  /// Relative Vertical Alignment.
  /// </summary>
  private static String? GetVerticalAlignment(DXDW.VerticalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDW.VerticalAlignment>()?.Text;
  }
  
  private static bool CmpVerticalAlignment(DXDW.VerticalPosition openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDW.VerticalAlignment>()?.Text == value;
  }
  
  private static void SetVerticalAlignment(DXDW.VerticalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.VerticalAlignment>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDW.VerticalAlignment { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PositionOffset.
  /// </summary>
  private static String? GetPositionOffset(DXDW.VerticalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDW.PositionOffset>()?.Text;
  }
  
  private static bool CmpPositionOffset(DXDW.VerticalPosition openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXDW.PositionOffset>()?.Text == value;
  }
  
  private static void SetPositionOffset(DXDW.VerticalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDW.PositionOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDW.PositionOffset { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// PercentagePositionVerticalOffset, this property is only available in Office 2010 and later..
  /// </summary>
  private static String? GetPercentagePositionVerticalOffset(DXDW.VerticalPosition openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO10WD.PercentagePositionVerticalOffset>()?.Text;
  }
  
  private static bool CmpPercentagePositionVerticalOffset(DXDW.VerticalPosition openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO10WD.PercentagePositionVerticalOffset>()?.Text == value;
  }
  
  private static void SetPercentagePositionVerticalOffset(DXDW.VerticalPosition openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO10WD.PercentagePositionVerticalOffset>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO10WD.PercentagePositionVerticalOffset { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMD.Wordprocessing.VerticalPosition? CreateModelElement(DXDW.VerticalPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Wordprocessing.VerticalPosition();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.VerticalAlignment = GetVerticalAlignment(openXmlElement);
      value.PositionOffset = GetPositionOffset(openXmlElement);
      value.PercentagePositionVerticalOffset = GetPercentagePositionVerticalOffset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDW.VerticalPosition? openXmlElement, DMDW.VerticalPosition? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpRelativeFrom(openXmlElement, value.RelativeFrom, diffs, objName, propName))
        ok = false;
      if (!CmpVerticalAlignment(openXmlElement, value.VerticalAlignment, diffs, objName, propName))
        ok = false;
      if (!CmpPositionOffset(openXmlElement, value.PositionOffset, diffs, objName, propName))
        ok = false;
      if (!CmpPercentagePositionVerticalOffset(openXmlElement, value.PercentagePositionVerticalOffset, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.VerticalPosition value)
    where OpenXmlElementType: DXDW.VerticalPosition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.VerticalPosition openXmlElement, DMDW.VerticalPosition value)
  {
    SetRelativeFrom(openXmlElement, value?.RelativeFrom);
    SetVerticalAlignment(openXmlElement, value?.VerticalAlignment);
    SetPositionOffset(openXmlElement, value?.PositionOffset);
    SetPercentagePositionVerticalOffset(openXmlElement, value?.PercentagePositionVerticalOffset);
  }
}
