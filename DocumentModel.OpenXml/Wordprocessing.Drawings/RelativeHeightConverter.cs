namespace DocumentModel.OpenXml.Wordprocessing.Drawings;

/// <summary>
/// Defines the RelativeHeight Class.
/// </summary>
public static class RelativeHeightConverter
{
  /// <summary>
  /// relativeFrom, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMWDraws.SizeRelativeVerticallyKind? GetRelativeFrom(DXO2010WDraw.RelativeHeight openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues, DMWDraws.SizeRelativeVerticallyKind>(openXmlElement?.RelativeFrom?.Value);
  }
  
  private static void SetRelativeFrom(DXO2010WDraw.RelativeHeight openXmlElement, DMWDraws.SizeRelativeVerticallyKind? value)
  {
    openXmlElement.RelativeFrom = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.Drawing.SizeRelativeVerticallyValues, DMWDraws.SizeRelativeVerticallyKind>(value);
  }
  
  /// <summary>
  /// PercentageHeight.
  /// </summary>
  private static String? GetPercentageHeight(DXO2010WDraw.RelativeHeight openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2010WDraw.PercentageHeight>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetPercentageHeight(DXO2010WDraw.RelativeHeight openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010WDraw.PercentageHeight>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2010WDraw.PercentageHeight { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMWDraws.RelativeHeight? CreateModelElement(DXO2010WDraw.RelativeHeight? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMWDraws.RelativeHeight();
      value.RelativeFrom = GetRelativeFrom(openXmlElement);
      value.PercentageHeight = GetPercentageHeight(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMWDraws.RelativeHeight? value)
    where OpenXmlElementType: DXO2010WDraw.RelativeHeight, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRelativeFrom(openXmlElement, value?.RelativeFrom);
      SetPercentageHeight(openXmlElement, value?.PercentageHeight);
      return openXmlElement;
    }
    return default;
  }
}
