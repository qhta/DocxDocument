namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartData Class.
/// </summary>
public static class ChartDataConverter
{
  /// <summary>
  /// ExternalData.
  /// </summary>
  private static DMDrawsChartDraws.ExternalData? GetExternalData(DXO2016DrawChartDraw.ChartData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExternalData>();
    if (element != null)
      return DMXDrawsChartDraws.ExternalDataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExternalData(DXO2016DrawChartDraw.ChartData openXmlElement, DMDrawsChartDraws.ExternalData? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExternalDataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExternalData>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExternalData(DXO2016DrawChartDraw.ChartData openXmlElement, DMDrawsChartDraws.ExternalData? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExternalData>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ExternalDataConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ExternalData>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.Data? GetData(DXO2016DrawChartDraw.ChartData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Data>();
    if (element != null)
      return DMXDrawsChartDraws.DataConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpData(DXO2016DrawChartDraw.ChartData openXmlElement, DMDrawsChartDraws.Data? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.DataConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Data>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetData(DXO2016DrawChartDraw.ChartData openXmlElement, DMDrawsChartDraws.Data? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Data>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.DataConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Data>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.ChartData openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.ChartData openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.ChartData openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.ChartData? CreateModelElement(DXO2016DrawChartDraw.ChartData? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartData();
      value.ExternalData = GetExternalData(openXmlElement);
      value.Data = GetData(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.ChartData? openXmlElement, DMDrawsChartDraws.ChartData? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpExternalData(openXmlElement, value.ExternalData, diffs, objName))
        ok = false;
      if (!CmpData(openXmlElement, value.Data, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ChartData? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ChartData, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetExternalData(openXmlElement, value?.ExternalData);
      SetData(openXmlElement, value?.Data);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
