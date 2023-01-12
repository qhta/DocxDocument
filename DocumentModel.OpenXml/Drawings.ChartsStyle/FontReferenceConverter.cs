namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the FontReference Class.
/// </summary>
public static class FontReferenceConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.Drawings.FontCollectionIndexKind? GetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DocumentModel.Drawings.FontCollectionIndexKind>(openXmlElement?.Index?.Value);
  }
  
  public static void SetIndex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.FontCollectionIndexKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Index = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.FontCollectionIndexValues, DocumentModel.Drawings.FontCollectionIndexKind>(value);
  }
  
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  public static DocumentModel.ListOf<String>? GetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.StringValue] type");
  }
  
  public static void SetModifiers(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.ListOf<String>? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: ListValue<> property is of DocumentFormat.OpenXml.ListValue`1[DocumentFormat.OpenXml.StringValue] type");
  }
  
  public static DocumentModel.Drawings.RgbColorModelPercentage? GetRgbColorModelPercentage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRgbColorModelPercentage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.RgbColorModelPercentage? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RgbColorModelPercentageConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.RgbColorModelHex? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.RgbColorModelHexConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.HslColor? GetHslColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HslColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetHslColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.HslColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.HslColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.HslColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.SystemColor? GetSystemColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSystemColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.SystemColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SystemColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SystemColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSchemeColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.SchemeColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.SchemeColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.SchemeColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.PresetColor? GetPresetColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPresetColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.PresetColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.PresetColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.PresetColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.StyleColor? GetStyleColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.StyleColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetStyleColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement, DocumentModel.Drawings.ChartsStyle.StyleColor? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.StyleColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleColor>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.FontReference? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.FontReference();
      value.Index = GetIndex(openXmlElement);
      value.Modifiers = GetModifiers(openXmlElement);
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      value.StyleColor = GetStyleColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.FontReference? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.FontReference, new()
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
