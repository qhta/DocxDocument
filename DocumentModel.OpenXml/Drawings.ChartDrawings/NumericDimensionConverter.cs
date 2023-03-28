namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the NumericDimension Class converter from/to OpenXml.
///</summary>
public static class NumericDimensionConverter
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.NumericDimensionType? GetType(DXO2016DrawChartDraw.NumericDimension openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DMDrawsChartDraws.NumericDimensionType>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXO2016DrawChartDraw.NumericDimension openXmlElement, DMDrawsChartDraws.NumericDimensionType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DMDrawsChartDraws.NumericDimensionType>(openXmlElement?.Type?.Value, value, diffs, objName);
  }
  
  private static void SetType(DXO2016DrawChartDraw.NumericDimension openXmlElement, DMDrawsChartDraws.NumericDimensionType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumericDimensionType, DMDrawsChartDraws.NumericDimensionType>(value);
  }
  
  private static DMDrawsChartDraws.OpenXmlFormulaElement? GetFormula(DXO2016DrawChartDraw.NumericDimension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Formula>();
    if (element != null)
      return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormula(DXO2016DrawChartDraw.NumericDimension openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Formula>(), value, diffs, objName);
  }
  
  private static void SetFormula(DXO2016DrawChartDraw.NumericDimension openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Formula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Formula>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.OpenXmlFormulaElement? GetNfFormula(DXO2016DrawChartDraw.NumericDimension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NfFormula>();
    if (element != null)
      return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNfFormula(DXO2016DrawChartDraw.NumericDimension openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NfFormula>(), value, diffs, objName);
  }
  
  private static void SetNfFormula(DXO2016DrawChartDraw.NumericDimension openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NfFormula>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.NfFormula>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Collection<DMDrawsChartDraws.NumericLevel>? GetNumericLevels(DXO2016DrawChartDraw.NumericDimension openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.NumericLevel>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.NumericLevel>())
    {
      var newItem = DMXDrawsChartDraws.NumericLevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    if (collection.Count>0)
      return collection;
    return null;
  }
  
  private static bool CmpNumericLevels(DXO2016DrawChartDraw.NumericDimension openXmlElement, Collection<DMDrawsChartDraws.NumericLevel>? value, DiffList? diffs, string? objName)
  {
    var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.NumericLevel>();
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
        if (!DMXDrawsChartDraws.NumericLevelConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (origElementsCount == 0 && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetNumericLevels(DXO2016DrawChartDraw.NumericDimension openXmlElement, Collection<DMDrawsChartDraws.NumericLevel>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.NumericLevel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.NumericLevelConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.NumericLevel>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsChartDraws.NumericLevel? GetNumericLevel(DXO2016DrawChartDraw.NumericDimension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumericLevel>();
    if (element != null)
      return DMXDrawsChartDraws.NumericLevelConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumericLevel(DXO2016DrawChartDraw.NumericDimension openXmlElement, DMDrawsChartDraws.NumericLevel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.NumericLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumericLevel>(), value, diffs, objName);
  }
  
  private static void SetNumericLevel(DXO2016DrawChartDraw.NumericDimension openXmlElement, DMDrawsChartDraws.NumericLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumericLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.NumericLevelConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.NumericLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.NumericDimension? CreateModelElement(DXO2016DrawChartDraw.NumericDimension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.NumericDimension();
      value.Type = GetType(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      value.NfFormula = GetNfFormula(openXmlElement);
      value.NumericLevels = GetNumericLevels(openXmlElement);
      value.NumericLevel = GetNumericLevel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.NumericDimension? openXmlElement, DMDrawsChartDraws.NumericDimension? value, DiffList? diffs, string? objName)
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
      if (!CmpNumericLevels(openXmlElement, value.NumericLevels, diffs, objName))
        ok = false;
      if (!CmpNumericLevel(openXmlElement, value.NumericLevel, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.NumericDimension value)
    where OpenXmlElementType: DXO2016DrawChartDraw.NumericDimension, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.NumericDimension openXmlElement, DMDrawsChartDraws.NumericDimension value)
  {
    SetType(openXmlElement, value?.Type);
    SetFormula(openXmlElement, value?.Formula);
    SetNfFormula(openXmlElement, value?.NfFormula);
    SetNumericLevels(openXmlElement, value?.NumericLevels);
    SetNumericLevel(openXmlElement, value?.NumericLevel);
  }
}
