namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the InvertSolidFillFormat Class.
/// </summary>
public static class InvertSolidFillFormatConverter
{
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsCharts.ShapeProperties2? GetShapeProperties(DXO2010DrawCharts.InvertSolidFillFormat openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2010DrawCharts.ShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ShapeProperties2Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXO2010DrawCharts.InvertSolidFillFormat openXmlElement, DMDrawsCharts.ShapeProperties2? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ShapeProperties2Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2010DrawCharts.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXO2010DrawCharts.InvertSolidFillFormat openXmlElement, DMDrawsCharts.ShapeProperties2? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2010DrawCharts.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ShapeProperties2Converter.CreateOpenXmlElement<DXO2010DrawCharts.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.InvertSolidFillFormat? CreateModelElement(DXO2010DrawCharts.InvertSolidFillFormat? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.InvertSolidFillFormat();
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010DrawCharts.InvertSolidFillFormat? openXmlElement, DMDrawsCharts.InvertSolidFillFormat? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.InvertSolidFillFormat value)
    where OpenXmlElementType: DXO2010DrawCharts.InvertSolidFillFormat, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2010DrawCharts.InvertSolidFillFormat openXmlElement, DMDrawsCharts.InvertSolidFillFormat value)
  {
    SetShapeProperties(openXmlElement, value?.ShapeProperties);
  }
}
