namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartTitle Class.
/// </summary>
public static class ChartTitleConverter
{
  /// <summary>
  /// pos, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.SidePos? GetPos(DXO2016DrawChartDraw.ChartTitle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DMDrawsChartDraws.SidePos>(openXmlElement?.Pos?.Value);
  }
  
  private static void SetPos(DXO2016DrawChartDraw.ChartTitle openXmlElement, DMDrawsChartDraws.SidePos? value)
  {
    openXmlElement.Pos = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SidePos, DMDrawsChartDraws.SidePos>(value);
  }
  
  /// <summary>
  /// align, this property is only available in Office 2016 and later.
  /// </summary>
  private static DMDrawsChartDraws.PosAlign? GetAlign(DXO2016DrawChartDraw.ChartTitle openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DMDrawsChartDraws.PosAlign>(openXmlElement?.Align?.Value);
  }
  
  private static void SetAlign(DXO2016DrawChartDraw.ChartTitle openXmlElement, DMDrawsChartDraws.PosAlign? value)
  {
    openXmlElement.Align = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PosAlign, DMDrawsChartDraws.PosAlign>(value);
  }
  
  /// <summary>
  /// overlay, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetOverlay(DXO2016DrawChartDraw.ChartTitle openXmlElement)
  {
    return openXmlElement?.Overlay?.Value;
  }
  
  private static void SetOverlay(DXO2016DrawChartDraw.ChartTitle openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Overlay = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Overlay = null;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  private static DMDrawsChartDraws.Text? GetText(DXO2016DrawChartDraw.ChartTitle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.Text>();
    if (itemElement != null)
      return DMXDrawsChartDraws.TextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetText(DXO2016DrawChartDraw.ChartTitle openXmlElement, DMDrawsChartDraws.Text? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXO2016DrawChartDraw.Text>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDrawsChartDraws.TextConverter.CreateOpenXmlElement<DXO2016DrawChartDraw.Text>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DMDrawsChartDraws.ShapeProperties? GetShapeProperties(DXO2016DrawChartDraw.ChartTitle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ShapeProperties>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DXO2016DrawChartDraw.ChartTitle openXmlElement, DMDrawsChartDraws.ShapeProperties? value)
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
  private static DMDrawsChartDraws.TxPrTextBody? GetTxPrTextBody(DXO2016DrawChartDraw.ChartTitle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.TxPrTextBody>();
    if (itemElement != null)
      return DMXDrawsChartDraws.TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetTxPrTextBody(DXO2016DrawChartDraw.ChartTitle openXmlElement, DMDrawsChartDraws.TxPrTextBody? value)
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
  /// ExtensionList.
  /// </summary>
  private static DMDrawsChartDraws.ExtensionList? GetExtensionList(DXO2016DrawChartDraw.ChartTitle openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXO2016DrawChartDraw.ExtensionList>();
    if (itemElement != null)
      return DMXDrawsChartDraws.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DXO2016DrawChartDraw.ChartTitle openXmlElement, DMDrawsChartDraws.ExtensionList? value)
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
  
  public static DMDrawsChartDraws.ChartTitle? CreateModelElement(DXO2016DrawChartDraw.ChartTitle? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraws.ChartTitle();
      value.Pos = GetPos(openXmlElement);
      value.Align = GetAlign(openXmlElement);
      value.Overlay = GetOverlay(openXmlElement);
      value.Text = GetText(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraws.ChartTitle? value)
    where OpenXmlElementType: DXO2016DrawChartDraw.ChartTitle, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPos(openXmlElement, value?.Pos);
      SetAlign(openXmlElement, value?.Align);
      SetOverlay(openXmlElement, value?.Overlay);
      SetText(openXmlElement, value?.Text);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
