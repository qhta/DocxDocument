namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the AxisTitle Class.
/// </summary>
public static class AxisTitleConverter
{
  private static DMDrawsChartsStyle.LineReference? GetLineReference(DXO2013DrawChartStyle.AxisTitle openXmlElement)
  {
    return DMXDrawsChartsStyle.LineReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LineReference>());
  }
  
  private static bool CmpLineReference(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.LineReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.LineReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.LineReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLineReference(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.LineReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.LineReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.LineReferenceConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.LineReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static String? GetLineWidthScale(DXO2013DrawChartStyle.AxisTitle openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LineWidthScale>()?.Text;
  }
  
  private static bool CmpLineWidthScale(DXO2013DrawChartStyle.AxisTitle openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.LineWidthScale>()?.Text == value;
  }
  
  private static void SetLineWidthScale(DXO2013DrawChartStyle.AxisTitle openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.LineWidthScale>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2013DrawChartStyle.LineWidthScale { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartsStyle.FillReference? GetFillReference(DXO2013DrawChartStyle.AxisTitle openXmlElement)
  {
    return DMXDrawsChartsStyle.FillReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.FillReference>());
  }
  
  private static bool CmpFillReference(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.FillReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.FillReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.FillReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFillReference(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.FillReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.FillReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.FillReferenceConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.FillReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartsStyle.EffectReference? GetEffectReference(DXO2013DrawChartStyle.AxisTitle openXmlElement)
  {
    return DMXDrawsChartsStyle.EffectReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.EffectReference>());
  }
  
  private static bool CmpEffectReference(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.EffectReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.EffectReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.EffectReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetEffectReference(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.EffectReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.EffectReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.EffectReferenceConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.EffectReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartsStyle.FontReference? GetFontReference(DXO2013DrawChartStyle.AxisTitle openXmlElement)
  {
    return DMXDrawsChartsStyle.FontReferenceConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.FontReference>());
  }
  
  private static bool CmpFontReference(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.FontReference? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.FontReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.FontReference>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFontReference(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.FontReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.FontReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.FontReferenceConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.FontReference>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartsStyle.ShapeProperties? GetShapeProperties(DXO2013DrawChartStyle.AxisTitle openXmlElement)
  {
    return DMXDrawsChartsStyle.ShapePropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.ShapeProperties>());
  }
  
  private static bool CmpShapeProperties(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.ShapePropertiesConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartsStyle.TextCharacterPropertiesType? GetTextCharacterPropertiesType(DXO2013DrawChartStyle.AxisTitle openXmlElement)
  {
    return DMXDrawsChartsStyle.TextCharacterPropertiesTypeConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TextCharacterPropertiesType>());
  }
  
  private static bool CmpTextCharacterPropertiesType(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.TextCharacterPropertiesType? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.TextCharacterPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TextCharacterPropertiesType>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextCharacterPropertiesType(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.TextCharacterPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TextCharacterPropertiesType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.TextCharacterPropertiesTypeConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.TextCharacterPropertiesType>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartsStyle.TextBodyProperties? GetTextBodyProperties(DXO2013DrawChartStyle.AxisTitle openXmlElement)
  {
    return DMXDrawsChartsStyle.TextBodyPropertiesConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.TextBodyProperties>());
  }
  
  private static bool CmpTextBodyProperties(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.TextBodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.TextBodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TextBodyProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTextBodyProperties(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.TextBodyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.TextBodyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.TextBodyPropertiesConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.TextBodyProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartsStyle.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO2013DrawChartStyle.AxisTitle openXmlElement)
  {
    return DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>());
  }
  
  private static bool CmpOfficeArtExtensionList(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetOfficeArtExtensionList(DXO2013DrawChartStyle.AxisTitle openXmlElement, DMDrawsChartsStyle.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChartStyle.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartsStyle.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO2013DrawChartStyle.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartsStyle.AxisTitle? CreateModelElement(DXO2013DrawChartStyle.AxisTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartsStyle.AxisTitle();
      value.LineReference = GetLineReference(openXmlElement);
      value.LineWidthScale = GetLineWidthScale(openXmlElement);
      value.FillReference = GetFillReference(openXmlElement);
      value.EffectReference = GetEffectReference(openXmlElement);
      value.FontReference = GetFontReference(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TextCharacterPropertiesType = GetTextCharacterPropertiesType(openXmlElement);
      value.TextBodyProperties = GetTextBodyProperties(openXmlElement);
      value.OfficeArtExtensionList = GetOfficeArtExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2013DrawChartStyle.AxisTitle? openXmlElement, DMDrawsChartsStyle.AxisTitle? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLineReference(openXmlElement, value.LineReference, diffs, objName))
        ok = false;
      if (!CmpLineWidthScale(openXmlElement, value.LineWidthScale, diffs, objName))
        ok = false;
      if (!CmpFillReference(openXmlElement, value.FillReference, diffs, objName))
        ok = false;
      if (!CmpEffectReference(openXmlElement, value.EffectReference, diffs, objName))
        ok = false;
      if (!CmpFontReference(openXmlElement, value.FontReference, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpTextCharacterPropertiesType(openXmlElement, value.TextCharacterPropertiesType, diffs, objName))
        ok = false;
      if (!CmpTextBodyProperties(openXmlElement, value.TextBodyProperties, diffs, objName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartsStyle.AxisTitle? value)
    where OpenXmlElementType: DXO2013DrawChartStyle.AxisTitle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLineReference(openXmlElement, value?.LineReference);
      SetLineWidthScale(openXmlElement, value?.LineWidthScale);
      SetFillReference(openXmlElement, value?.FillReference);
      SetEffectReference(openXmlElement, value?.EffectReference);
      SetFontReference(openXmlElement, value?.FontReference);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTextCharacterPropertiesType(openXmlElement, value?.TextCharacterPropertiesType);
      SetTextBodyProperties(openXmlElement, value?.TextBodyProperties);
      SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
