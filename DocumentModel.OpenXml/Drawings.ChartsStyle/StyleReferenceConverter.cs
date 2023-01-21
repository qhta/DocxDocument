namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public static class StyleReferenceConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetIndex(DXO2013DrawChartStyle.StyleReference openXmlElement)
  {
    return openXmlElement.Index?.Value;
  }
  
  private static void SetIndex(DXO2013DrawChartStyle.StyleReference openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  private static DM.ListOf<String>? GetModifiers(DXO2013DrawChartStyle.StyleReference openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Modifiers);
  }
  
  private static void SetModifiers(DXO2013DrawChartStyle.StyleReference openXmlElement, DM.ListOf<String>? value)
  {
    if (value != null)
      openXmlElement.Modifiers = ListValueConverter.CreateListValue<DX.StringValue>(value);
    else
      openXmlElement.Modifiers = null;
  }
  
  public static DMDrawsChartsStyle.StyleReference? CreateModelElement(DXO2013DrawChartStyle.StyleReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartsStyle.StyleReference();
      value.Index = GetIndex(openXmlElement);
      value.Modifiers = GetModifiers(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.StyleReference? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.StyleReference, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIndex(openXmlElement, value?.Index);
      SetModifiers(openXmlElement, value?.Modifiers);
      return openXmlElement;
    }
    return default;
  }
}
