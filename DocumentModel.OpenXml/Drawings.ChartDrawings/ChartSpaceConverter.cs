using DocumentModel.Drawings.ChartDrawings;
using ChartSpace = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the ChartSpace Class.
/// </summary>
public static class ChartSpaceConverter
{
  /// <summary>
  ///   ChartData.
  /// </summary>
  public static ChartData? GetChartData(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>();
    if (itemElement != null)
      return ChartDataConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartData(ChartSpace? openXmlElement, ChartData? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartData>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Chart.
  /// </summary>
  public static Chart? GetChart(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>();
    if (itemElement != null)
      return ChartConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChart(ChartSpace? openXmlElement, Chart? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Chart>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public static ShapeProperties? GetShapeProperties(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(ChartSpace? openXmlElement, ShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   TxPrTextBody.
  /// </summary>
  public static TxPrTextBody? GetTxPrTextBody(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTxPrTextBody(ChartSpace? openXmlElement, TxPrTextBody? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TxPrTextBodyConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ColorMappingType.
  /// </summary>
  public static ColorMappingType? GetColorMappingType(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>();
    if (itemElement != null)
      return ColorMappingTypeConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetColorMappingType(ChartSpace? openXmlElement, ColorMappingType? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMappingTypeConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ColorMappingType>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   FormatOverrides.
  /// </summary>
  public static FormatOverrides? GetFormatOverrides(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides>();
    if (itemElement != null)
      return FormatOverridesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetFormatOverrides(ChartSpace? openXmlElement, FormatOverrides? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormatOverridesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.FormatOverrides>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   PrintSettings.
  /// </summary>
  public static PrintSettings? GetPrintSettings(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings>();
    if (itemElement != null)
      return PrintSettingsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPrintSettings(ChartSpace? openXmlElement, PrintSettings? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintSettingsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PrintSettings>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(ChartSpace? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ChartSpace? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ChartSpace? CreateModelElement(ChartSpace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ChartSpace();
      value.ChartData = GetChartData(openXmlElement);
      value.Chart = GetChart(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ColorMappingType = GetColorMappingType(openXmlElement);
      value.FormatOverrides = GetFormatOverrides(openXmlElement);
      value.PrintSettings = GetPrintSettings(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ChartSpace? value)
    where OpenXmlElementType : ChartSpace, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartData(openXmlElement, value?.ChartData);
      SetChart(openXmlElement, value?.Chart);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetColorMappingType(openXmlElement, value?.ColorMappingType);
      SetFormatOverrides(openXmlElement, value?.FormatOverrides);
      SetPrintSettings(openXmlElement, value?.PrintSettings);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}