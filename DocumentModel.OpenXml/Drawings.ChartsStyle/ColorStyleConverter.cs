namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public static class ColorStyleConverter
{
  /// <summary>
  /// meth, this property is only available in Office 2013 and later.
  /// </summary>
  private static String? GetMethod(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    return openXmlElement?.Method?.Value;
  }
  
  private static void SetMethod(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Method = new StringValue { Value = value };
    else
      openXmlElement.Method = null;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2013 and later.
  /// </summary>
  private static UInt32? GetId(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    return openXmlElement.Id?.Value;
  }
  
  private static void SetId(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  private static DocumentModel.Drawings.RgbColorModelPercentage? GetRgbColorModelPercentage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelPercentage>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RgbColorModelPercentageConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelPercentage(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, DocumentModel.Drawings.RgbColorModelPercentage? value)
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
  
  private static DocumentModel.Drawings.RgbColorModelHex? GetRgbColorModelHex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.RgbColorModelHex>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RgbColorModelHexConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRgbColorModelHex(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, DocumentModel.Drawings.RgbColorModelHex? value)
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
  
  private static DocumentModel.Drawings.HslColor? GetHslColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.HslColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.HslColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetHslColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, DocumentModel.Drawings.HslColor? value)
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
  
  private static DocumentModel.Drawings.SystemColor? GetSystemColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SystemColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SystemColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSystemColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, DocumentModel.Drawings.SystemColor? value)
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
  
  private static DocumentModel.Drawings.SchemeColor? GetSchemeColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.SchemeColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.SchemeColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSchemeColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, DocumentModel.Drawings.SchemeColor? value)
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
  
  private static DocumentModel.Drawings.PresetColor? GetPresetColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.PresetColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.PresetColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetPresetColor(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, DocumentModel.Drawings.PresetColor? value)
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
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation> GetColorStyleVariations(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.ChartsStyle.ColorStyleVariationConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetColorStyleVariations(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartsStyle.ColorStyleVariation>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartsStyle.ColorStyleVariationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyleVariation>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartsStyle.OfficeArtExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetOfficeArtExtensionList(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle openXmlElement, DocumentModel.Drawings.ChartsStyle.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartsStyle.OfficeArtExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.ColorStyle? CreateModelElement(DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.ColorStyle();
      value.Method = GetMethod(openXmlElement);
      value.Id = GetId(openXmlElement);
      value.RgbColorModelPercentage = GetRgbColorModelPercentage(openXmlElement);
      value.RgbColorModelHex = GetRgbColorModelHex(openXmlElement);
      value.HslColor = GetHslColor(openXmlElement);
      value.SystemColor = GetSystemColor(openXmlElement);
      value.SchemeColor = GetSchemeColor(openXmlElement);
      value.PresetColor = GetPresetColor(openXmlElement);
      value.ColorStyleVariations = GetColorStyleVariations(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartsStyle.ColorStyle? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMethod(openXmlElement, value?.Method);
      SetId(openXmlElement, value?.Id);
      SetRgbColorModelPercentage(openXmlElement, value?.RgbColorModelPercentage);
      SetRgbColorModelHex(openXmlElement, value?.RgbColorModelHex);
      SetHslColor(openXmlElement, value?.HslColor);
      SetSystemColor(openXmlElement, value?.SystemColor);
      SetSchemeColor(openXmlElement, value?.SchemeColor);
      SetPresetColor(openXmlElement, value?.PresetColor);
      SetColorStyleVariations(openXmlElement, value?.ColorStyleVariations);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
