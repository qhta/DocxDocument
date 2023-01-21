namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MajorTickMarksTickMarks Class.
/// </summary>
public static class MajorTickMarksTickMarksConverter
{
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.MajorTickMarksTickMarks openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.MajorTickMarksTickMarks openXmlElement, DMDrawsChartDraws.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ExtensionListConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraws.MajorTickMarksTickMarks? CreateModelElement(DXO2016DrawChartDraw.MajorTickMarksTickMarks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.MajorTickMarksTickMarks();
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.MajorTickMarksTickMarks? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.MajorTickMarksTickMarks, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
