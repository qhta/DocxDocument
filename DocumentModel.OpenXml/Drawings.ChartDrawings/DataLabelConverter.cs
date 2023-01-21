namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabel Class.
/// </summary>
public static class DataLabelConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIdx(DXO2016DrawChartDraw.DataLabel openXmlElement)
  {
    return openXmlElement.Idx?.Value;
  }
  
  private static void SetIdx(DXO2016DrawChartDraw.DataLabel openXmlElement, UInt32? value)
  {
    openXmlElement.Idx = value;
  }
  
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.DataLabelPos? GetPos(DXO2016DrawChartDraw.DataLabel openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDrawsChartDraws.DataLabelPos>(openXmlElement?.Pos?.Value);
  }
  
  private static void SetPos(DXO2016DrawChartDraw.DataLabel openXmlElement, DMDrawsChartDraws.DataLabelPos? value)
  {
    openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabelPos, DMDrawsChartDraws.DataLabelPos>(value);
  }
  
  /// <summary>
  /// NumberFormat.
  /// </summary>
  private static DMDrawsChartDraws.NumberFormat? GetNumberFormat(DXO2016DrawChartDraw.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.NumberFormat>();
    if (itemElement != null)
      return DMXDrawsChartDraws.NumberFormatConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetNumberFormat(DXO2016DrawChartDraw.DataLabel openXmlElement, DMDrawsChartDraws.NumberFormat? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.NumberFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.NumberFormatConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.NumberFormat>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.DataLabel openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.ShapePropertiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// TxPrTextBody.
  /// </summary>
  private static DMDrawsChartDraws.TxPrTextBody? GetTxPrTextBody(DXO2016DrawChartDraw.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (itemElement != null)
      return DMXDrawsChartDraws.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTxPrTextBody(DXO2016DrawChartDraw.DataLabel openXmlElement, DMDrawsChartDraws.TxPrTextBody? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.TxPrTextBodyConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.TxPrTextBody>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DataLabelVisibilities.
  /// </summary>
  private static DMDrawsChartDraws.DataLabelVisibilities? GetDataLabelVisibilities(DXO2016DrawChartDraw.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.DataLabelVisibilities>();
    if (itemElement != null)
      return DMXDrawsChartDraws.DataLabelVisibilitiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabelVisibilities(DXO2016DrawChartDraw.DataLabel openXmlElement, DMDrawsChartDraws.DataLabelVisibilities? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.DataLabelVisibilities>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.DataLabelVisibilitiesConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.DataLabelVisibilities>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// SeparatorXsdstring.
  /// </summary>
  private static String? GetSeparatorXsdstring(DXO2016DrawChartDraw.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.SeparatorXsdstring>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetSeparatorXsdstring(DXO2016DrawChartDraw.DataLabel openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.SeparatorXsdstring>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXO2016DrawChartDraw.SeparatorXsdstring { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.DataLabel openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.DataLabel openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraws.DataLabel? CreateModelElement(DXO2016DrawChartDraw.DataLabel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.DataLabel();
      value.Idx = GetIdx(openXmlElement);
      value.Pos = GetPos(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.DataLabelVisibilities = GetDataLabelVisibilities(openXmlElement);
      value.SeparatorXsdstring = GetSeparatorXsdstring(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.DataLabel? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.DataLabel, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetIdx(openXmlElement, value?.Idx);
      SetPos(openXmlElement, value?.Pos);
      SetNumberFormat(openXmlElement, value?.NumberFormat);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetDataLabelVisibilities(openXmlElement, value?.DataLabelVisibilities);
      SetSeparatorXsdstring(openXmlElement, value?.SeparatorXsdstring);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
