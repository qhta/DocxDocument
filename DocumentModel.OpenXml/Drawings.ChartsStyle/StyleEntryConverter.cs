namespace DocumentModel.OpenXml.Drawings.ChartsStyle;

/// <summary>
/// Defines the StyleEntry Class.
/// </summary>
public static class StyleEntryConverter
{
  /// <summary>
  /// mods, this property is only available in Office 2013 and later.
  /// </summary>
  private static DM.ListOf<String>? GetModifiers(DXO13DCS.StyleEntry openXmlElement)
  {
    return ListValueConverter.GetValue(openXmlElement?.Modifiers);
  }
  
  private static bool CmpModifiers(DXO13DCS.StyleEntry openXmlElement, DM.ListOf<String>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return ListValueConverter.CmpValue(openXmlElement?.Modifiers, value, diffs, objName, propName);
  }
  
  private static void SetModifiers(DXO13DCS.StyleEntry openXmlElement, DM.ListOf<String>? value)
  {
    if (value != null)
      openXmlElement.Modifiers = ListValueConverter.CreateListValue<DX.StringValue>(value);
    else
      openXmlElement.Modifiers = null;
  }
  
  /// <summary>
  /// LineReference.
  /// </summary>
  private static DMDCS.LineReference? GetLineReference(DXO13DCS.StyleEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.LineReference>();
    if (element != null)
      return DMXDCS.LineReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLineReference(DXO13DCS.StyleEntry openXmlElement, DMDCS.LineReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCS.LineReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.LineReference>(), value, diffs, objName, propName);
  }
  
  private static void SetLineReference(DXO13DCS.StyleEntry openXmlElement, DMDCS.LineReference? value)
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
  
  /// <summary>
  /// LineWidthScale.
  /// </summary>
  private static String? GetLineWidthScale(DXO13DCS.StyleEntry openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO13DCS.LineWidthScale>()?.Text;
  }
  
  private static bool CmpLineWidthScale(DXO13DCS.StyleEntry openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
      return openXmlElement?.GetFirstChild<DXO13DCS.LineWidthScale>()?.Text == value;
  }
  
  private static void SetLineWidthScale(DXO13DCS.StyleEntry openXmlElement, String? value)
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
  
  /// <summary>
  /// FillReference.
  /// </summary>
  private static DMDCS.FillReference? GetFillReference(DXO13DCS.StyleEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.FillReference>();
    if (element != null)
      return DMXDCS.FillReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFillReference(DXO13DCS.StyleEntry openXmlElement, DMDCS.FillReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCS.FillReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.FillReference>(), value, diffs, objName, propName);
  }
  
  private static void SetFillReference(DXO13DCS.StyleEntry openXmlElement, DMDCS.FillReference? value)
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
  
  /// <summary>
  /// EffectReference.
  /// </summary>
  private static DMDCS.EffectReference? GetEffectReference(DXO13DCS.StyleEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.EffectReference>();
    if (element != null)
      return DMXDCS.EffectReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpEffectReference(DXO13DCS.StyleEntry openXmlElement, DMDCS.EffectReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCS.EffectReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.EffectReference>(), value, diffs, objName, propName);
  }
  
  private static void SetEffectReference(DXO13DCS.StyleEntry openXmlElement, DMDCS.EffectReference? value)
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
  
  /// <summary>
  /// FontReference.
  /// </summary>
  private static DMDCS.FontReference? GetFontReference(DXO13DCS.StyleEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.FontReference>();
    if (element != null)
      return DMXDCS.FontReferenceConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFontReference(DXO13DCS.StyleEntry openXmlElement, DMDCS.FontReference? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCS.FontReferenceConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.FontReference>(), value, diffs, objName, propName);
  }
  
  private static void SetFontReference(DXO13DCS.StyleEntry openXmlElement, DMDCS.FontReference? value)
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
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDCS.ShapeProperties? GetShapeProperties(DXO13DCS.StyleEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.ShapeProperties>();
    if (element != null)
      return DMXDCS.ShapePropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO13DCS.StyleEntry openXmlElement, DMDCS.ShapeProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCS.ShapePropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.ShapeProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetShapeProperties(DXO13DCS.StyleEntry openXmlElement, DMDCS.ShapeProperties? value)
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
  
  /// <summary>
  /// TextCharacterPropertiesType.
  /// </summary>
  private static DMDCS.TextCharacterPropertiesType? GetTextCharacterPropertiesType(DXO13DCS.StyleEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.TextCharacterPropertiesType>();
    if (element != null)
      return DMXDCS.TextCharacterPropertiesTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextCharacterPropertiesType(DXO13DCS.StyleEntry openXmlElement, DMDCS.TextCharacterPropertiesType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCS.TextCharacterPropertiesTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.TextCharacterPropertiesType>(), value, diffs, objName, propName);
  }
  
  private static void SetTextCharacterPropertiesType(DXO13DCS.StyleEntry openXmlElement, DMDCS.TextCharacterPropertiesType? value)
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
  
  /// <summary>
  /// TextBodyProperties.
  /// </summary>
  private static DMDCS.TextBodyProperties? GetTextBodyProperties(DXO13DCS.StyleEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.TextBodyProperties>();
    if (element != null)
      return DMXDCS.TextBodyPropertiesConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTextBodyProperties(DXO13DCS.StyleEntry openXmlElement, DMDCS.TextBodyProperties? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCS.TextBodyPropertiesConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.TextBodyProperties>(), value, diffs, objName, propName);
  }
  
  private static void SetTextBodyProperties(DXO13DCS.StyleEntry openXmlElement, DMDCS.TextBodyProperties? value)
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
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  private static DMDCS.OfficeArtExtensionList? GetOfficeArtExtensionList(DXO13DCS.StyleEntry openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO13DCS.OfficeArtExtensionList>();
    if (element != null)
      return DMXDCS.OfficeArtExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpOfficeArtExtensionList(DXO13DCS.StyleEntry openXmlElement, DMDCS.OfficeArtExtensionList? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCS.OfficeArtExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO13DCS.OfficeArtExtensionList>(), value, diffs, objName, propName);
  }
  
  private static void SetOfficeArtExtensionList(DXO13DCS.StyleEntry openXmlElement, DMDCS.OfficeArtExtensionList? value)
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
  
  public static DMDCS.StyleEntry? CreateModelElement(DXO13DCS.StyleEntry? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCS.StyleEntry();
      value.Modifiers = GetModifiers(openXmlElement);
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
  
  public static bool CompareModelElement(DXO13DCS.StyleEntry? openXmlElement, DMDCS.StyleEntry? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpModifiers(openXmlElement, value.Modifiers, diffs, objName, propName))
        ok = false;
      if (!CmpLineReference(openXmlElement, value.LineReference, diffs, objName, propName))
        ok = false;
      if (!CmpLineWidthScale(openXmlElement, value.LineWidthScale, diffs, objName, propName))
        ok = false;
      if (!CmpFillReference(openXmlElement, value.FillReference, diffs, objName, propName))
        ok = false;
      if (!CmpEffectReference(openXmlElement, value.EffectReference, diffs, objName, propName))
        ok = false;
      if (!CmpFontReference(openXmlElement, value.FontReference, diffs, objName, propName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName, propName))
        ok = false;
      if (!CmpTextCharacterPropertiesType(openXmlElement, value.TextCharacterPropertiesType, diffs, objName, propName))
        ok = false;
      if (!CmpTextBodyProperties(openXmlElement, value.TextBodyProperties, diffs, objName, propName))
        ok = false;
      if (!CmpOfficeArtExtensionList(openXmlElement, value.OfficeArtExtensionList, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCS.StyleEntry value)
    where OpenXmlElementType: DXO13DCS.StyleEntry, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO13DCS.StyleEntry openXmlElement, DMDCS.StyleEntry value)
  {
    SetModifiers(openXmlElement, value?.Modifiers);
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
