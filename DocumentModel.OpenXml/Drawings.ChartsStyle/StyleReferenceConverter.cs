namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleReference Class.
/// </summary>
public static class StyleReferenceConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference openXmlElement)
  {
    return openXmlElement.Index?.Value;
  }
  
  private static void SetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  private static DocumentModel.ListOf<String>? GetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Modifiers);
  }
  
  private static void SetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference openXmlElement, DocumentModel.ListOf<String>? value)
  {
    if (value != null)
      openXmlElement.Modifiers = ListValueConverter.CreateListValue<DocumentFormat.OpenXml.StringValue>(value);
    else
      openXmlElement.Modifiers = null;
  }
  
  public static DocumentModel.Drawings.ChartsStyle.StyleReference? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.StyleReference();
      value.Index = GetIndex(openXmlElement);
      value.Modifiers = GetModifiers(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.StyleReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference, new()
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
