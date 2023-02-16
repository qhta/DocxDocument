namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public static class TextDataConverter
{
  private static DMDrawsChartDraws.OpenXmlFormulaElement? GetFormula(DXO2016DrawChartDraw.TextData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Formula>();
    if (element != null)
      return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpFormula(DXO2016DrawChartDraw.TextData openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Formula>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetFormula(DXO2016DrawChartDraw.TextData openXmlElement, DMDrawsChartDraws.OpenXmlFormulaElement? value)
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
  
  private static String? GetVXsdstring(DXO2016DrawChartDraw.TextData openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.VXsdstring>()?.Text;
  }
  
  private static bool CmpVXsdstring(DXO2016DrawChartDraw.TextData openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.VXsdstring>()?.Text == value;
  }
  
  private static void SetVXsdstring(DXO2016DrawChartDraw.TextData openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.VXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.VXsdstring { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.TextData? CreateModelElement(DXO2016DrawChartDraw.TextData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.TextData();
      value.Formula = GetFormula(openXmlElement);
      value.VXsdstring = GetVXsdstring(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.TextData? openXmlElement, DMDrawsChartDraws.TextData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpFormula(openXmlElement, value.Formula, diffs, objName))
        ok = false;
      if (!CmpVXsdstring(openXmlElement, value.VXsdstring, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.TextData? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.TextData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetFormula(openXmlElement, value?.Formula);
      SetVXsdstring(openXmlElement, value?.VXsdstring);
      return openXmlElement;
    }
    return default;
  }
}
