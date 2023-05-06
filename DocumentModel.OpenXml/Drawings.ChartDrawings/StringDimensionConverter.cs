namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public static class StringDimensionConverter
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDCDs.StringDimensionType? GetType(DXO16DCD.StringDimension openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DMDCDs.StringDimensionType>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXO16DCD.StringDimension openXmlElement, DMDCDs.StringDimensionType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DMDCDs.StringDimensionType>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXO16DCD.StringDimension openXmlElement, DMDCDs.StringDimensionType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DMDCDs.StringDimensionType>(value);
  }
  
  private static DMDCDs.OpenXmlFormulaElement? GetFormula(DXO16DCD.StringDimension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.Formula>();
    if (element != null)
      return DMXDCDs.OpenXmlFormulaElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormula(DXO16DCD.StringDimension openXmlElement, DMDCDs.OpenXmlFormulaElement? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.Formula>(), value, diffs, objName);
  }
  
  private static void SetFormula(DXO16DCD.StringDimension openXmlElement, DMDCDs.OpenXmlFormulaElement? value)
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
  
  private static DMDCDs.OpenXmlFormulaElement? GetNfFormula(DXO16DCD.StringDimension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.NfFormula>();
    if (element != null)
      return DMXDCDs.OpenXmlFormulaElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNfFormula(DXO16DCD.StringDimension openXmlElement, DMDCDs.OpenXmlFormulaElement? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.NfFormula>(), value, diffs, objName);
  }
  
  private static void SetNfFormula(DXO16DCD.StringDimension openXmlElement, DMDCDs.OpenXmlFormulaElement? value)
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
  
  private static Collection<DMDCDs.StringLevel>? GetStringLevels(DXO16DCD.StringDimension openXmlElement)
  {
    var collection = new Collection<DMDCDs.StringLevel>();
    foreach (var item in openXmlElement.Elements<DXO16DCD.StringLevel>())
    {
      var newItem = DMXDCDs.StringLevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpStringLevels(DXO16DCD.StringDimension openXmlElement, Collection<DMDCDs.StringLevel>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO16DCD.StringLevel>();
    var origElementsCount = origElements.Count();
    var modelElementsCount = value?.Count() ?? 0;
    if (value != null)
    {
      if (origElementsCount != modelElementsCount)
      {
        diffs?.Add(objName, openXmlElement.GetType().Name+".Count", origElementsCount, modelElementsCount);
        return false;
      }
      var ok = true;
      var modelEnumerator = value.GetEnumerator();
      foreach (var origItem in origElements)
      {
        modelEnumerator.MoveNext();
        var modelItem = modelEnumerator.Current;
        if (!DMXDCDs.StringLevelConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStringLevels(DXO16DCD.StringDimension openXmlElement, Collection<DMDCDs.StringLevel>? value)
  {
    openXmlElement.RemoveAllChildren<DXO16DCD.StringLevel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDCDs.StringLevelConverter.CreateOpenXmlElement<DXO16DCD.StringLevel>(item);
        if (newItem != null)
          openXmlElement.AppendChild(newItem);
      }
    }
  }
  
  private static DMDCDs.StringLevel? GetStringLevel(DXO16DCD.StringDimension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO16DCD.StringLevel>();
    if (element != null)
      return DMXDCDs.StringLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringLevel(DXO16DCD.StringDimension openXmlElement, DMDCDs.StringLevel? value, DiffList? diffs, string? objName)
  {
    return DMXDCDs.StringLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO16DCD.StringLevel>(), value, diffs, objName);
  }
  
  private static void SetStringLevel(DXO16DCD.StringDimension openXmlElement, DMDCDs.StringLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO16DCD.StringLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDCDs.StringLevelConverter.CreateOpenXmlElement<DXO16DCD.StringLevel>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.StringDimension? CreateModelElement(DXO16DCD.StringDimension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.StringDimension();
      value.Type = GetType(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      value.NfFormula = GetNfFormula(openXmlElement);
      value.StringLevels = GetStringLevels(openXmlElement);
      value.StringLevel = GetStringLevel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.StringDimension? openXmlElement, DMDCDs.StringDimension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpType(openXmlElement, value.Type, diffs, objName))
        ok = false;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName))
        ok = false;
      if (!CmpNfFormula(openXmlElement, value.NfFormula, diffs, objName))
        ok = false;
      if (!CmpStringLevels(openXmlElement, value.StringLevels, diffs, objName))
        ok = false;
      if (!CmpStringLevel(openXmlElement, value.StringLevel, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.StringDimension value)
    where OpenXmlElementType: DXO16DCD.StringDimension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.StringDimension openXmlElement, DMDCDs.StringDimension value)
  {
    SetType(openXmlElement, value?.Type);
    SetFormula(openXmlElement, value?.Formula);
    SetNfFormula(openXmlElement, value?.NfFormula);
    SetStringLevels(openXmlElement, value?.StringLevels);
    SetStringLevel(openXmlElement, value?.StringLevel);
  }
}
