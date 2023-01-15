using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using Marker = DocumentFormat.OpenXml.Office2013.Drawing.Chart.Marker;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the Marker Class.
/// </summary>
public static class Marker3Converter
{
  /// <summary>
  ///   Symbol.
  /// </summary>
  public static MarkerStyleKind? GetSymbol(Marker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Symbol>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<MarkerStyleValues, MarkerStyleKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetSymbol(Marker? openXmlElement, MarkerStyleKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Symbol>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Symbol, MarkerStyleValues, MarkerStyleKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Size.
  /// </summary>
  public static Byte? GetSize(Marker? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Size>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSize(Marker? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Size>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Size { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public static ChartShapeProperties? GetChartShapeProperties(Marker? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(Marker? openXmlElement, ChartShapeProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(Marker? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Marker? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Marker3? CreateModelElement(Marker? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new Marker3();
      value.Symbol = GetSymbol(openXmlElement);
      value.Size = GetSize(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(Marker3? value)
    where OpenXmlElementType : Marker, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSymbol(openXmlElement, value?.Symbol);
      SetSize(openXmlElement, value?.Size);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}