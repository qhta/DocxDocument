namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the PlotArea Class.
/// </summary>
public static class PlotAreaConverter
{
  private static DMDCS.LineReference? GetLineReference(DXO13DCS.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.LineReference>();
    if (element != null)
      return DMXDCS.LineReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineReference(DXO13DCS.PlotArea openXmlElement, DMDCS.LineReference? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.LineReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.LineReference>(), value, diffs, objName);
  }
  
  private static void SetLineReference(DXO13DCS.PlotArea openXmlElement, DMDCS.LineReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.LineReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.LineReferenceConverter.CreateOpenXmlElement<DXO13DCS.LineReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static String? GetLineWidthScale(DXO13DCS.PlotArea openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO13DCS.LineWidthScale>()?.Text;
  }
  
  private static bool CmpLineWidthScale(DXO13DCS.PlotArea openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO13DCS.LineWidthScale>()?.Text == value;
  }
  
  private static void SetLineWidthScale(DXO13DCS.PlotArea openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.LineWidthScale>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO13DCS.LineWidthScale { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCS.FillReference? GetFillReference(DXO13DCS.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.FillReference>();
    if (element != null)
      return DMXDCS.FillReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillReference(DXO13DCS.PlotArea openXmlElement, DMDCS.FillReference? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.FillReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.FillReference>(), value, diffs, objName);
  }
  
  private static void SetFillReference(DXO13DCS.PlotArea openXmlElement, DMDCS.FillReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.FillReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.FillReferenceConverter.CreateOpenXmlElement<DXO13DCS.FillReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCS.EffectReference? GetEffectReference(DXO13DCS.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.EffectReference>();
    if (element != null)
      return DMXDCS.EffectReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectReference(DXO13DCS.PlotArea openXmlElement, DMDCS.EffectReference? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.EffectReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.EffectReference>(), value, diffs, objName);
  }
  
  private static void SetEffectReference(DXO13DCS.PlotArea openXmlElement, DMDCS.EffectReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.EffectReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.EffectReferenceConverter.CreateOpenXmlElement<DXO13DCS.EffectReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCS.FontReference? GetFontReference(DXO13DCS.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.FontReference>();
    if (element != null)
      return DMXDCS.FontReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontReference(DXO13DCS.PlotArea openXmlElement, DMDCS.FontReference? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.FontReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.FontReference>(), value, diffs, objName);
  }
  
  private static void SetFontReference(DXO13DCS.PlotArea openXmlElement, DMDCS.FontReference? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.FontReference>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.FontReferenceConverter.CreateOpenXmlElement<DXO13DCS.FontReference>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCS.ShapeProperties? GetShapeProperties(DXO13DCS.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.ShapeProperties>();
    if (element != null)
      return DMXDCS.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO13DCS.PlotArea openXmlElement, DMDCS.ShapeProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.ShapeProperties>(), value, diffs, objName);
  }
  
  private static void SetShapeProperties(DXO13DCS.PlotArea openXmlElement, DMDCS.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.ShapePropertiesConverter.CreateOpenXmlElement<DXO13DCS.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCS.TextCharacterPropertiesType? GetTextCharacterPropertiesType(DXO13DCS.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.TextCharacterPropertiesType>();
    if (element != null)
      return DMXDCS.TextCharacterPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextCharacterPropertiesType(DXO13DCS.PlotArea openXmlElement, DMDCS.TextCharacterPropertiesType? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.TextCharacterPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.TextCharacterPropertiesType>(), value, diffs, objName);
  }
  
  private static void SetTextCharacterPropertiesType(DXO13DCS.PlotArea openXmlElement, DMDCS.TextCharacterPropertiesType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.TextCharacterPropertiesType>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.TextCharacterPropertiesTypeConverter.CreateOpenXmlElement<DXO13DCS.TextCharacterPropertiesType>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCS.TextBodyProperties? GetTextBodyProperties(DXO13DCS.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.TextBodyProperties>();
    if (element != null)
      return DMXDCS.TextBodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBodyProperties(DXO13DCS.PlotArea openXmlElement, DMDCS.TextBodyProperties? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.TextBodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.TextBodyProperties>(), value, diffs, objName);
  }
  
  private static void SetTextBodyProperties(DXO13DCS.PlotArea openXmlElement, DMDCS.TextBodyProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.TextBodyProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.TextBodyPropertiesConverter.CreateOpenXmlElement<DXO13DCS.TextBodyProperties>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCS.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO13DCS.PlotArea openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.OfficeArtExtensionList>();
    if (element != null)
      return DMXDCS.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO13DCS.PlotArea openXmlElement, DMDCS.OfficeArtExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDCS.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.OfficeArtExtensionList>(), value, diffs, objName);
  }
  
  private static void SetOfficeArtExtensionList(DXO13DCS.PlotArea openXmlElement, DMDCS.OfficeArtExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO13DCS.OfficeArtExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCS.OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO13DCS.OfficeArtExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartsStyle.PlotArea? CreateModelElement(DXO13DCS.PlotArea? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartsStyle.PlotArea();
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
  
  public static bool CompareModelElement(DXO13DCS.PlotArea? openXmlElement, DMDCS.PlotArea? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.PlotArea value)
    where OpenXmlElementType: DXO13DCS.PlotArea, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.PlotArea openXmlElement, DMDCS.PlotArea value)
  {
    SetLineReference(openXmlElement, value?.LineReference);
    SetLineWidthScale(openXmlElement, value?.LineWidthScale);
    SetFillReference(openXmlElement, value?.FillReference);
    SetEffectReference(openXmlElement, value?.EffectReference);
    SetFontReference(openXmlElement, value?.FontReference);
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
    SetTextCharacterPropertiesType(openXmlElement, value?.TextCharacterPropertiesType);
    SetTextBodyProperties(openXmlElement, value?.TextBodyProperties);
    SetOfficeArtExtensionList(openXmlElement, value?.OfficeArtExtensionList);
  }
}
