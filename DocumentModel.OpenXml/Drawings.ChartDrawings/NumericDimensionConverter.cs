namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericDimension Class.
/// </summary>
public static class NumericDimensionConverter
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.NumericDimensionType? GetType(DXO16DCD.NumericDimension openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DMDCDs.NumericDimensionType>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXO16DCD.NumericDimension openXmlElement, DMDCDs.NumericDimensionType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DMDCDs.NumericDimensionType>(openXmlElement?.Type?.Value, value, diffs, objName, propName);
  }
  
  private static void SetType(DXO16DCD.NumericDimension openXmlElement, DMDCDs.NumericDimensionType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DMDCDs.NumericDimensionType>(value);
  }
  
  private static DMDCDs.OpenXmlFormulaElement? GetFormula(DXO16DCD.NumericDimension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Formula>();
    if (element != null)
      return DMXDCDs.OpenXmlFormulaElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormula(DXO16DCD.NumericDimension openXmlElement, DMDCDs.OpenXmlFormulaElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Formula>(), value, diffs, objName, propName);
  }
  
  private static void SetFormula(DXO16DCD.NumericDimension openXmlElement, DMDCDs.OpenXmlFormulaElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.OpenXmlFormulaElementConverter.CreateOpenXmlElement<DXO16DCD.Formula>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static DMDCDs.OpenXmlFormulaElement? GetNfFormula(DXO16DCD.NumericDimension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.NfFormula>();
    if (element != null)
      return DMXDCDs.OpenXmlFormulaElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNfFormula(DXO16DCD.NumericDimension openXmlElement, DMDCDs.OpenXmlFormulaElement? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.NfFormula>(), value, diffs, objName, propName);
  }
  
  private static void SetNfFormula(DXO16DCD.NumericDimension openXmlElement, DMDCDs.OpenXmlFormulaElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.NfFormula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.OpenXmlFormulaElementConverter.CreateOpenXmlElement<DXO16DCD.NfFormula>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  private static Collection<DMDCDs.NumericLevel>? GetNumericLevels(DXO16DCD.NumericDimension openXmlElement)
  {
    var collection = new Collection<DMDCDs.NumericLevel>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.NumericLevel>())
    {
      var newItem = DMXDCDs.NumericLevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumericLevels(DXO16DCD.NumericDimension openXmlElement, Collection<DMDCDs.NumericLevel>? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.NumericLevel>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, propName ?? openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDCDs.NumericLevelConverter.CompareModelElement(origItem, modelItem, diffs, objName, propName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumericLevels(DXO16DCD.NumericDimension openXmlElement, Collection<DMDCDs.NumericLevel>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.NumericLevel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.NumericLevelConverter.CreateOpenXmlElement<DXO16DCD.NumericLevel>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDCDs.NumericLevel? GetNumericLevel(DXO16DCD.NumericDimension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.NumericLevel>();
    if (element != null)
      return DMXDCDs.NumericLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumericLevel(DXO16DCD.NumericDimension openXmlElement, DMDCDs.NumericLevel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXDCDs.NumericLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.NumericLevel>(), value, diffs, objName, propName);
  }
  
  private static void SetNumericLevel(DXO16DCD.NumericDimension openXmlElement, DMDCDs.NumericLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.NumericLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.NumericLevelConverter.CreateOpenXmlElement<DXO16DCD.NumericLevel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DMDCDs.NumericDimension? CreateModelElement(DXO16DCD.NumericDimension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.NumericDimension();
      value.Type = GetType(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      value.NfFormula = GetNfFormula(openXmlElement);
      value.NumericLevels = GetNumericLevels(openXmlElement);
      value.NumericLevel = GetNumericLevel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.NumericDimension? openXmlElement, DMDCDs.NumericDimension? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName, propName))
        ok = false;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName, propName))
        ok = false;
      if (!CmpNfFormula(openXmlElement, value.NfFormula, diffs, objName, propName))
        ok = false;
      if (!CmpNumericLevels(openXmlElement, value.NumericLevels, diffs, objName, propName))
        ok = false;
      if (!CmpNumericLevel(openXmlElement, value.NumericLevel, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.NumericDimension value)
    where OpenXmlElementType: DXO16DCD.NumericDimension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.NumericDimension openXmlElement, DMDCDs.NumericDimension value)
  {
    SetType(openXmlElement, value?.Type);
    SetFormula(openXmlElement, value?.Formula);
    SetNfFormula(openXmlElement, value?.NfFormula);
    SetNumericLevels(openXmlElement, value?.NumericLevels);
    SetNumericLevel(openXmlElement, value?.NumericLevel);
  }
}
