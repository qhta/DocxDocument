namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the SdtContentCheckBox Class.
/// </summary>
public static class SdtContentCheckBoxConverter
{
  /// <summary>
  /// Checked.
  /// </summary>
  private static DMW.OnOffKind? GetChecked(DXO2010W.SdtContentCheckBox openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.Checked>()?.Val?.Value);
  }
  
  private static bool CmpChecked(DXO2010W.SdtContentCheckBox openXmlElement, DMW.OnOffKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(openXmlElement.GetFirstChild<DXO2010W.Checked>()?.Val?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetChecked(DXO2010W.SdtContentCheckBox openXmlElement, DMW.OnOffKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.Checked>();
    if (itemElement != null)
    {
      if (value != null)
        EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>(itemElement, (DMW.OnOffKind)value);
      else
        itemElement.Remove();
    }
    else
    if (value != null)
      openXmlElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXO2010W.Checked, DocumentFormat.OpenXml.Office2010.Word.OnOffValues, DMW.OnOffKind>((DMW.OnOffKind)value));
  }
  
  /// <summary>
  /// CheckedState.
  /// </summary>
  private static DMW.CheckBoxSymbolType? GetCheckedState(DXO2010W.SdtContentCheckBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.CheckedState>();
    if (element != null)
      return DMXW.CheckBoxSymbolTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpCheckedState(DXO2010W.SdtContentCheckBox openXmlElement, DMW.CheckBoxSymbolType? value, DiffList? diffs, string? objName)
  {
    return DMXW.CheckBoxSymbolTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.CheckedState>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetCheckedState(DXO2010W.SdtContentCheckBox openXmlElement, DMW.CheckBoxSymbolType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.CheckedState>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CheckBoxSymbolTypeConverter.CreateOpenXmlElement<DXO2010W.CheckedState>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// UncheckedState.
  /// </summary>
  private static DMW.CheckBoxSymbolType? GetUncheckedState(DXO2010W.SdtContentCheckBox openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010W.UncheckedState>();
    if (element != null)
      return DMXW.CheckBoxSymbolTypeConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpUncheckedState(DXO2010W.SdtContentCheckBox openXmlElement, DMW.CheckBoxSymbolType? value, DiffList? diffs, string? objName)
  {
    return DMXW.CheckBoxSymbolTypeConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010W.UncheckedState>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetUncheckedState(DXO2010W.SdtContentCheckBox openXmlElement, DMW.CheckBoxSymbolType? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010W.UncheckedState>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXW.CheckBoxSymbolTypeConverter.CreateOpenXmlElement<DXO2010W.UncheckedState>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Wordprocessing.SdtContentCheckBox? CreateModelElement(DXO2010W.SdtContentCheckBox? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtContentCheckBox();
      value.Checked = GetChecked(openXmlElement);
      value.CheckedState = GetCheckedState(openXmlElement);
      value.UncheckedState = GetUncheckedState(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.SdtContentCheckBox? openXmlElement, DMW.SdtContentCheckBox? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpChecked(openXmlElement, value.Checked, diffs, objName))
        ok = false;
      if (!CmpCheckedState(openXmlElement, value.CheckedState, diffs, objName))
        ok = false;
      if (!CmpUncheckedState(openXmlElement, value.UncheckedState, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.SdtContentCheckBox value)
    where OpenXmlElementType: DXO2010W.SdtContentCheckBox, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010W.SdtContentCheckBox openXmlElement, DMW.SdtContentCheckBox value)
  {
    SetChecked(openXmlElement, value?.Checked);
    SetCheckedState(openXmlElement, value?.CheckedState);
    SetUncheckedState(openXmlElement, value?.UncheckedState);
  }
}
