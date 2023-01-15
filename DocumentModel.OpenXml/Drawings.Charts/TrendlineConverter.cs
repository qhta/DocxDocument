using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using Trendline = DocumentFormat.OpenXml.Drawing.Charts.Trendline;
using TrendlineLabel = DocumentModel.Drawings.Charts.TrendlineLabel;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the Trendline Class.
/// </summary>
public static class TrendlineConverter
{
  /// <summary>
  ///   Trendline Name.
  /// </summary>
  public static String? GetTrendlineName(Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TrendlineName>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }

  public static void SetTrendlineName(Trendline? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TrendlineName>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TrendlineName { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public static ChartShapeProperties? GetChartShapeProperties(Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(Trendline? openXmlElement, ChartShapeProperties? value)
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
  ///   Trendline Type.
  /// </summary>
  public static TrendlineKind? GetTrendlineType(Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TrendlineType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TrendlineValues, TrendlineKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTrendlineType(Trendline? openXmlElement, TrendlineKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TrendlineType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TrendlineType, TrendlineValues, TrendlineKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Polynomial Trendline Order.
  /// </summary>
  public static Byte? GetPolynomialOrder(Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<PolynomialOrder>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPolynomialOrder(Trendline? openXmlElement, Byte? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<PolynomialOrder>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new PolynomialOrder { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Period.
  /// </summary>
  public static UInt32? GetPeriod(Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Period>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetPeriod(Trendline? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Period>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Period { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Forward.
  /// </summary>
  public static Double? GetForward(Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Forward>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetForward(Trendline? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Forward>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Forward { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Backward.
  /// </summary>
  public static Double? GetBackward(Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Backward>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetBackward(Trendline? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Backward>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Backward { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Intercept.
  /// </summary>
  public static Double? GetIntercept(Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<Intercept>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetIntercept(Trendline? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Intercept>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new Intercept { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Display R Squared Value.
  /// </summary>
  public static Boolean? GetDisplayRSquaredValue(Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayRSquaredValue>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDisplayRSquaredValue(Trendline? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DisplayRSquaredValue>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DisplayRSquaredValue();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Display Equation.
  /// </summary>
  public static Boolean? GetDisplayEquation(Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DisplayEquation>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDisplayEquation(Trendline? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DisplayEquation>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DisplayEquation();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Trendline Label.
  /// </summary>
  public static TrendlineLabel? GetTrendlineLabel(Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel>();
    if (itemElement != null)
      return TrendlineLabelConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTrendlineLabel(Trendline? openXmlElement, TrendlineLabel? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TrendlineLabelConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TrendlineLabel>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ExtensionList? GetExtensionList(Trendline? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Trendline? openXmlElement, DocumentModel.Drawings.Charts.ExtensionList? value)
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

  public static DocumentModel.Drawings.Charts.Trendline? CreateModelElement(Trendline? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Trendline();
      value.TrendlineName = GetTrendlineName(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TrendlineType = GetTrendlineType(openXmlElement);
      value.PolynomialOrder = GetPolynomialOrder(openXmlElement);
      value.Period = GetPeriod(openXmlElement);
      value.Forward = GetForward(openXmlElement);
      value.Backward = GetBackward(openXmlElement);
      value.Intercept = GetIntercept(openXmlElement);
      value.DisplayRSquaredValue = GetDisplayRSquaredValue(openXmlElement);
      value.DisplayEquation = GetDisplayEquation(openXmlElement);
      value.TrendlineLabel = GetTrendlineLabel(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Trendline? value)
    where OpenXmlElementType : Trendline, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetTrendlineName(openXmlElement, value?.TrendlineName);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTrendlineType(openXmlElement, value?.TrendlineType);
      SetPolynomialOrder(openXmlElement, value?.PolynomialOrder);
      SetPeriod(openXmlElement, value?.Period);
      SetForward(openXmlElement, value?.Forward);
      SetBackward(openXmlElement, value?.Backward);
      SetIntercept(openXmlElement, value?.Intercept);
      SetDisplayRSquaredValue(openXmlElement, value?.DisplayRSquaredValue);
      SetDisplayEquation(openXmlElement, value?.DisplayEquation);
      SetTrendlineLabel(openXmlElement, value?.TrendlineLabel);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}