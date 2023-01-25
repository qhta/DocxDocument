namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the StringDimension Class.
/// </summary>
public static class StringDimensionConverter
{
  /// <summary>
  /// type, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.StringDimensionType? GetType(DXO2016DrawChartDraw.StringDimension openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DMDrawsChartDraws.StringDimensionType>(openXmlElement?.Type?.Value);
  }
  
  private static bool CmpType(DXO2016DrawChartDraw.StringDimension openXmlElement, DMDrawsChartDraws.StringDimensionType? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DMDrawsChartDraws.StringDimensionType>(openXmlElement?.Type?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetType(DXO2016DrawChartDraw.StringDimension openXmlElement, DMDrawsChartDraws.StringDimensionType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DMDrawsChartDraws.StringDimensionType>(value);
  }
  
  private static DMDrawsChartDraws.OpenXmlFormulaElement? GetFormula(DXO2016DrawChartDraw.StringDimension openXmlElement)
  {
    return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Formula>());
  }
  
  private static bool CmpFormula(DXO2016DrawChartDraw.StringDimension openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Formula>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFormula(DXO2016DrawChartDraw.StringDimension openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value)
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
  
  private static DMDrawsChartDraws.OpenXmlFormulaElement? GetNfFormula(DXO2016DrawChartDraw.StringDimension openXmlElement)
  {
    return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NfFormula>());
  }
  
  private static bool CmpNfFormula(DXO2016DrawChartDraw.StringDimension openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NfFormula>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNfFormula(DXO2016DrawChartDraw.StringDimension openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value)
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
  
  private static Collection<DMDrawsChartDraws.StringLevel> GetStringLevels(DXO2016DrawChartDraw.StringDimension openXmlElement)
  {
    var collection = new Collection<DMDrawsChartDraws.StringLevel>();
    foreach (var item in openXmlElement.Elements<DXO2016DrawChartDraw.StringLevel>())
    {
      var newItem = DMXDrawsChartDraws.StringLevelConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static bool CmpStringLevels(DXO2016DrawChartDraw.StringDimension openXmlElement, Collection<DMDrawsChartDraws.StringLevel>? value, DiffList? diffs, string? objName)
  {
    if (value != null)
    {
      var origElements = openXmlElement.Elements<DXO2016DrawChartDraw.StringLevel>();
      var origElementsCount = origElements.Count();
      var modelElementsCount = value.Count();
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
        if (!DMXDrawsChartDraws.StringLevelConverter.CompareModelElement(origItem, modelItem, diffs, objName))
          ok = false;
      }
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  private static void SetStringLevels(DXO2016DrawChartDraw.StringDimension openXmlElement, Collection<DMDrawsChartDraws.StringLevel>? value)
  {
    openXmlElement.RemoveAllChildren<DXO2016DrawChartDraw.StringLevel>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DMXDrawsChartDraws.StringLevelConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.StringLevel>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DMDrawsChartDraws.StringLevel? GetStringLevel(DXO2016DrawChartDraw.StringDimension openXmlElement)
  {
    return DMXDrawsChartDraws.StringLevelConverter.CreateModelElement(openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.StringLevel>());
  }
  
  private static bool CmpStringLevel(DXO2016DrawChartDraw.StringDimension openXmlElement, DMDrawsChartDraws.StringLevel? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.StringLevelConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.StringLevel>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStringLevel(DXO2016DrawChartDraw.StringDimension openXmlElement, DMDrawsChartDraws.StringLevel? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.StringLevel>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.StringLevelConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.StringLevel>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.StringDimension? CreateModelElement(DXO2016DrawChartDraw.StringDimension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.StringDimension();
      value.Type = GetType(openXmlElement);
      value.Formula = GetFormula(openXmlElement);
      value.NfFormula = GetNfFormula(openXmlElement);
      value.StringLevels = GetStringLevels(openXmlElement);
      value.StringLevel = GetStringLevel(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.StringDimension? openXmlElement, DMDrawsChartDraws.StringDimension? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.StringDimension? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.StringDimension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetFormula(openXmlElement, value?.Formula);
      SetNfFormula(openXmlElement, value?.NfFormula);
      SetStringLevels(openXmlElement, value?.StringLevels);
      SetStringLevel(openXmlElement, value?.StringLevel);
      return openXmlElement;
    }
    return default;
  }
}
