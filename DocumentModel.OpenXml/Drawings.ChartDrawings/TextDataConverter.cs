namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the TextData Class.
/// </summary>
public static class TextDataConverter
{
  private static DMDrawsChartDraws.OpenXmlFormulaElement? GetFormula(DXO2016DrawChartDraw.TextData openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Formula>();
    if (itemElement != null)
      return DMXDrawsChartDraws.OpenXmlFormulaElementConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.VXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
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
  
  public static DMDrawsChartDraws.TextData? CreateModelElement(DXO2016DrawChartDraw.TextData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.TextData();
      value.Formula = GetFormula(openXmlElement);
      value.VXsdstring = GetVXsdstring(openXmlElement);
      return value;
    }
    return null;
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
