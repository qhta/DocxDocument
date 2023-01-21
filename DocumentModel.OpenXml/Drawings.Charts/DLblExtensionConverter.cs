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
  
  private static void SetUri(DXDrawCharts.DLblExtension openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Uri = new StringValue { Value = value };
    else
      openXmlElement.Uri = null;
  }
  
  private static DMDrawsCharts.DataLabelFieldTable? GetDataLabelFieldTable(DXDrawCharts.DLblExtension openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.DataLabelFieldTable>();
    if (itemElement != null)
      return DMXDrawsCharts.DataLabelFieldTableConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ExceptionForSave>();
    return itemElement != null;
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
    var itemElement = openXmlElement.GetFirstChild<DXO2013DrawChart.ShowDataLabelsRange>();
    return itemElement != null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsCharts.ShapeProperties3Converter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXO2013DrawChart.Layout>();
    if (itemElement != null)
      return DMXDrawsCharts.Layout3Converter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDrawsCharts.DLblExtension? CreateModelElement(DXDrawCharts.DLblExtension? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsCharts.DLblExtension();
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
