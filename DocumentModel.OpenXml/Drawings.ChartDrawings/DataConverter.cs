namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Data Class.
/// </summary>
public static class DataConverter
{
  /// <summary>
  /// id, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetId(DXO2016DrawChartDraw.Data openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }
  
  private static bool CmpId(DXO2016DrawChartDraw.Data openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Id?.Value == value) return true;
    diffs?.Add(objName, "Id", openXmlElement?.Id?.Value, value);
    return false;
  }
  
  private static void SetId(DXO2016DrawChartDraw.Data openXmlElement, UInt32? value)
  {
    openXmlElement.Id = value;
  }
  
  private static DMDrawsChartDraws.NumericDimension? GetNumericDimension(DXO2016DrawChartDraw.Data openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumericDimension>();
    if (element != null)
      return DMXDrawsChartDraws.NumericDimensionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpNumericDimension(DXO2016DrawChartDraw.Data openXmlElement, DMDrawsChartDraws.NumericDimension? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.NumericDimensionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumericDimension>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetNumericDimension(DXO2016DrawChartDraw.Data openXmlElement, DMDrawsChartDraws.NumericDimension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumericDimension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.NumericDimensionConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.NumericDimension>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.StringDimension? GetStringDimension(DXO2016DrawChartDraw.Data openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.StringDimension>();
    if (element != null)
      return DMXDrawsChartDraws.StringDimensionConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpStringDimension(DXO2016DrawChartDraw.Data openXmlElement, DMDrawsChartDraws.StringDimension? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.StringDimensionConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.StringDimension>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetStringDimension(DXO2016DrawChartDraw.Data openXmlElement, DMDrawsChartDraws.StringDimension? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.StringDimension>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.StringDimensionConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.StringDimension>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.Data openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (element != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpExtensionList(DXO2016DrawChartDraw.Data openXmlElement, DMDrawsChartDraws.ExtensionList? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsChartDraws.ExtensionListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.Data openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DocumentModel.Drawings.ChartDrawings.Data? CreateModelElement(DXO2016DrawChartDraw.Data? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Data();
      value.Id = GetId(openXmlElement);
      value.NumericDimension = GetNumericDimension(openXmlElement);
      value.StringDimension = GetStringDimension(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2016DrawChartDraw.Data? openXmlElement, DMDrawsChartDraws.Data? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpId(openXmlElement, value.Id, diffs, objName))
        ok = false;
      if (!CmpNumericDimension(openXmlElement, value.NumericDimension, diffs, objName))
        ok = false;
      if (!CmpStringDimension(openXmlElement, value.StringDimension, diffs, objName))
        ok = false;
      if (!CmpExtensionList(openXmlElement, value.ExtensionList, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.Data? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.Data, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetNumericDimension(openXmlElement, value?.NumericDimension);
      SetStringDimension(openXmlElement, value?.StringDimension);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
