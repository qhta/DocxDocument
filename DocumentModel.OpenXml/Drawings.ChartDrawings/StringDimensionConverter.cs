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
  
  private static void SetType(DXO2016DrawChartDraw.StringDimension openXmlElement, DMDrawsChartDraws.StringDimensionType? value)
  {
    openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.StringDimensionType, DMDrawsChartDraws.StringDimensionType>(value);
  }
  
  private static DMDrawsChartDraws.OpenXmlFormulaElement? GetFormula(DXO2016DrawChartDraw.StringDimension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Formula>();
    if (itemElement != null)
      return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NfFormula>();
    if (itemElement != null)
      return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.StringLevel>();
    if (itemElement != null)
      return DMXDrawsChartDraws.StringLevelConverter.CreateModelElement(itemElement);
    return null;
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
