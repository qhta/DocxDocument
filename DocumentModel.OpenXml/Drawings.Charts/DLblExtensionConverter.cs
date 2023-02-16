namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the DLblExtension Class.
/// </summary>
public static class DLblExtensionConverter
{
  /// <summary>
  /// URI
  /// </summary>
  private static String? GetUri(DXDrawCharts.DLblExtension openXmlElement)
  {
    return openXmlElement?.Uri?.Value;
  }
  
  private static bool CmpUri(DXDrawCharts.DLblExtension openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Uri?.Value == value) return true;
    diffs?.Add(objName, "Uri", openXmlElement?.Uri?.Value, value);
    return false;
  }
  
  private static void SetUri(DXDrawCharts.DLblExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.DataLabelFieldTable? GetDataLabelFieldTable(DXDrawCharts.DLblExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelFieldTable>();
    if (element != null)
      return DMXDrawsCharts.DataLabelFieldTableConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDataLabelFieldTable(DXDrawCharts.DLblExtension openXmlElement, DMDrawsCharts.DataLabelFieldTable? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.DataLabelFieldTableConverter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelFieldTable>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDataLabelFieldTable(DXDrawCharts.DLblExtension openXmlElement, DMDrawsCharts.DataLabelFieldTable? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.DataLabelFieldTable>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.DataLabelFieldTableConverter.CreateOpenXmlElement<DXO2013DrawChart.DataLabelFieldTable>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetExceptionForSave(DXDrawCharts.DLblExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013DrawChart.ExceptionForSave>() != null;
  }
  
  private static bool CmpExceptionForSave(DXDrawCharts.DLblExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2013DrawChart.ExceptionForSave>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2013DrawChart.ExceptionForSave", val, value);
    return false;
  }
  
  private static void SetExceptionForSave(DXDrawCharts.DLblExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ExceptionForSave>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013DrawChart.ExceptionForSave();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static Boolean? GetShowDataLabelsRange(DXDrawCharts.DLblExtension openXmlElement)
  {
    return openXmlElement.GetFirstChild<DXO2013DrawChart.ShowDataLabelsRange>() != null;
  }
  
  private static bool CmpShowDataLabelsRange(DXDrawCharts.DLblExtension openXmlElement, Boolean? value, DiffList? diffs, string? objName)
  {
    var val = openXmlElement.GetFirstChild<DXO2013DrawChart.ShowDataLabelsRange>() != null;
    if (val == value) return true;
    diffs?.Add(objName, "DXO2013DrawChart.ShowDataLabelsRange", val, value);
    return false;
  }
  
  private static void SetShowDataLabelsRange(DXDrawCharts.DLblExtension openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ShowDataLabelsRange>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DXO2013DrawChart.ShowDataLabelsRange();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.ShapeProperties3? GetShapeProperties(DXDrawCharts.DLblExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.ShapeProperties>();
    if (element != null)
      return DMXDrawsCharts.ShapeProperties3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpShapeProperties(DXDrawCharts.DLblExtension openXmlElement, DMDrawsCharts.ShapeProperties3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.ShapeProperties3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.ShapeProperties>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetShapeProperties(DXDrawCharts.DLblExtension openXmlElement, DMDrawsCharts.ShapeProperties3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.ShapeProperties3Converter.CreateOpenXmlElement<DXO2013DrawChart.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DMDrawsCharts.Layout3? GetLayout(DXDrawCharts.DLblExtension openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXO2013DrawChart.Layout>();
    if (element != null)
      return DMXDrawsCharts.Layout3Converter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpLayout(DXDrawCharts.DLblExtension openXmlElement, DMDrawsCharts.Layout3? value, DiffList? diffs, string? objName)
  {
    return DMXDrawsCharts.Layout3Converter.CompareModelElement(openXmlElement.GetFirstChild<DXO2013DrawChart.Layout>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetLayout(DXDrawCharts.DLblExtension openXmlElement, DMDrawsCharts.Layout3? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.Layout>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsCharts.Layout3Converter.CreateOpenXmlElement<DXO2013DrawChart.Layout>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.DLblExtension? CreateModelElement(DXDrawCharts.DLblExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DLblExtension();
      value.Uri = GetUri(openXmlElement);
      value.DataLabelFieldTable = GetDataLabelFieldTable(openXmlElement);
      value.ExceptionForSave = GetExceptionForSave(openXmlElement);
      value.ShowDataLabelsRange = GetShowDataLabelsRange(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.Layout = GetLayout(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawCharts.DLblExtension? openXmlElement, DMDrawsCharts.DLblExtension? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpUri(openXmlElement, value.Uri, diffs, objName))
        ok = false;
      if (!CmpDataLabelFieldTable(openXmlElement, value.DataLabelFieldTable, diffs, objName))
        ok = false;
      if (!CmpExceptionForSave(openXmlElement, value.ExceptionForSave, diffs, objName))
        ok = false;
      if (!CmpShowDataLabelsRange(openXmlElement, value.ShowDataLabelsRange, diffs, objName))
        ok = false;
      if (!CmpShapeProperties(openXmlElement, value.ShapeProperties, diffs, objName))
        ok = false;
      if (!CmpLayout(openXmlElement, value.Layout, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsCharts.DLblExtension? value)
    where OpenXmlElementType: DXDrawCharts.DLblExtension, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetUri(openXmlElement, value?.Uri);
      SetDataLabelFieldTable(openXmlElement, value?.DataLabelFieldTable);
      SetExceptionForSave(openXmlElement, value?.ExceptionForSave);
      SetShowDataLabelsRange(openXmlElement, value?.ShowDataLabelsRange);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetLayout(openXmlElement, value?.Layout);
      return openXmlElement;
    }
    return default;
  }
}
