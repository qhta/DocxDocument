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
  
  private static void SetRelativeFrom(DXDrawW.HorizontalPosition openXmlElement, DMDrawsW.HorizontalRelativePositionKind? value)
  {
    openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.Wordprocessing.HorizontalRelativePositionValues, DMDrawsW.HorizontalRelativePositionKind>(value);
  }
  
  /// <summary>
  /// Relative Horizontal Alignment.
  /// </summary>
  private static String? GetHorizontalAlignment(DXDrawW.HorizontalPosition openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.HorizontalAlignment>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDrawW.PositionOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2010WDraw.PercentagePositionHeightOffset>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
  
  public static DMDrawsW.HorizontalPosition? CreateModelElement(DXDrawW.HorizontalPosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.HorizontalPosition();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.HorizontalAlignment = GetHorizontalAlignment(openXmlElement);
      value.PositionOffset = GetPositionOffset(openXmlElement);
      value.PercentagePositionHeightOffset = GetPercentagePositionHeightOffset(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.HorizontalPosition? value)
    where OpenXmlElementType: DXDrawW.HorizontalPosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeFrom(openXmlElement, value?.RelativeFrom);
      SetHorizontalAlignment(openXmlElement, value?.HorizontalAlignment);
      SetPositionOffset(openXmlElement, value?.PositionOffset);
      SetPercentagePositionHeightOffset(openXmlElement, value?.PercentagePositionHeightOffset);
      return openXmlElement;
    }
    return default;
  }
}
