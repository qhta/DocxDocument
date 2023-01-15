using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using ErrorBars = DocumentFormat.OpenXml.Drawing.Charts.ErrorBars;
using Minus = DocumentModel.Drawings.Charts.Minus;
using Plus = DocumentModel.Drawings.Charts.Plus;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the ErrorBars Class.
/// </summary>
public static class ErrorBarsConverter
{
  /// <summary>
  ///   Error Bar Direction.
  /// </summary>
  public static ErrorBarDirectionKind? GetErrorDirection(ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ErrorDirection>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<ErrorBarDirectionValues, ErrorBarDirectionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetErrorDirection(ErrorBars? openXmlElement, ErrorBarDirectionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ErrorDirection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ErrorDirection, ErrorBarDirectionValues, ErrorBarDirectionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Error Bar Type.
  /// </summary>
  public static ErrorBarKind? GetErrorBarType(ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ErrorBarType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<ErrorBarValues, ErrorBarKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetErrorBarType(ErrorBars? openXmlElement, ErrorBarKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ErrorBarType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ErrorBarType, ErrorBarValues, ErrorBarKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Error Bar Value Type.
  /// </summary>
  public static ErrorKind? GetErrorBarValueType(ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ErrorBarValueType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<ErrorValues, ErrorKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetErrorBarValueType(ErrorBars? openXmlElement, ErrorKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ErrorBarValueType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<ErrorBarValueType, ErrorValues, ErrorKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   No End Cap.
  /// </summary>
  public static Boolean? GetNoEndCap(ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoEndCap>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoEndCap(ErrorBars? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoEndCap>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoEndCap();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Plus.
  /// </summary>
  public static Plus? GetPlus(ErrorBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Plus>();
    if (itemElement != null)
      return PlusConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetPlus(ErrorBars? openXmlElement, Plus? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Plus>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PlusConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Plus>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Minus.
  /// </summary>
  public static Minus? GetMinus(ErrorBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Minus>();
    if (itemElement != null)
      return MinusConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinus(ErrorBars? openXmlElement, Minus? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Minus>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinusConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Minus>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Error Bar Value.
  /// </summary>
  public static Double? GetErrorBarValue(ErrorBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<ErrorBarValue>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetErrorBarValue(ErrorBars? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<ErrorBarValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new ErrorBarValue { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public static ChartShapeProperties? GetChartShapeProperties(ErrorBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(ErrorBars? openXmlElement, ChartShapeProperties? value)
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
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(ErrorBars? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(ErrorBars? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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

  public static DocumentModel.Drawings.Charts.ErrorBars? CreateModelElement(ErrorBars? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ErrorBars();
      value.ErrorDirection = GetErrorDirection(openXmlElement);
      value.ErrorBarType = GetErrorBarType(openXmlElement);
      value.ErrorBarValueType = GetErrorBarValueType(openXmlElement);
      value.NoEndCap = GetNoEndCap(openXmlElement);
      value.Plus = GetPlus(openXmlElement);
      value.Minus = GetMinus(openXmlElement);
      value.ErrorBarValue = GetErrorBarValue(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ErrorBars? value)
    where OpenXmlElementType : ErrorBars, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetErrorDirection(openXmlElement, value?.ErrorDirection);
      SetErrorBarType(openXmlElement, value?.ErrorBarType);
      SetErrorBarValueType(openXmlElement, value?.ErrorBarValueType);
      SetNoEndCap(openXmlElement, value?.NoEndCap);
      SetPlus(openXmlElement, value?.Plus);
      SetMinus(openXmlElement, value?.Minus);
      SetErrorBarValue(openXmlElement, value?.ErrorBarValue);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}