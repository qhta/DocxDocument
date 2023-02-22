namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the MinorTickMarksTickMarks Class.
/// </summary>
public static class MinorTickMarksTickMarksConverter
{
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.MinorTickMarksTickMarks openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.MinorTickMarksTickMarks openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.MinorTickMarksTickMarks openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.MinorTickMarksTickMarks? CreateModelElement(DXO2016DrawChartDraw.MinorTickMarksTickMarks? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.MinorTickMarksTickMarks();
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.MinorTickMarksTickMarks? openXmlElement, DMDrawsChartDraws.MinorTickMarksTickMarks? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.MinorTickMarksTickMarks value)
    where OpenXmlElementType: DXO2016DrawChartDraw.MinorTickMarksTickMarks, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO2016DrawChartDraw.MinorTickMarksTickMarks openXmlElement, DMDrawsChartDraws.MinorTickMarksTickMarks value)
  {
    SetExtensionList(openXmlElement, value?.ExtensionList);
    }
  }
