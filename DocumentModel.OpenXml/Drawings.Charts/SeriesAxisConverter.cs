using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using MajorGridlines = DocumentModel.Drawings.Charts.MajorGridlines;
using MinorGridlines = DocumentModel.Drawings.Charts.MinorGridlines;
using NumberingFormat = DocumentModel.Drawings.Charts.NumberingFormat;
using Scaling = DocumentModel.Drawings.Charts.Scaling;
using SerAxExtensionList = DocumentModel.Drawings.Charts.SerAxExtensionList;
using SeriesAxis = DocumentFormat.OpenXml.Drawing.Charts.SeriesAxis;
using TextProperties = DocumentModel.Drawings.Charts.TextProperties;
using Title = DocumentModel.Drawings.Charts.Title;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Series Axis.
/// </summary>
public static class SeriesAxisConverter
{
  /// <summary>
  ///   Axis ID.
  /// </summary>
  public static UInt32? GetAxisId(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AxisId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAxisId(SeriesAxis? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AxisId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new AxisId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Scaling.
  /// </summary>
  public static Scaling? GetScaling(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
    if (itemElement != null)
      return ScalingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScaling(SeriesAxis? openXmlElement, Scaling? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScalingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Scaling>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Delete.
  /// </summary>
  public static Boolean? GetDelete(SeriesAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Delete>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDelete(SeriesAxis? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Delete>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Delete();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Axis Position.
  /// </summary>
  public static AxisPositionKind? GetAxisPosition(SeriesAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AxisPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<AxisPositionValues, AxisPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAxisPosition(SeriesAxis? openXmlElement, AxisPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AxisPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<AxisPosition, AxisPositionValues, AxisPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Major Gridlines.
  /// </summary>
  public static MajorGridlines? GetMajorGridlines(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
    if (itemElement != null)
      return MajorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMajorGridlines(SeriesAxis? openXmlElement, MajorGridlines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorGridlinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Minor Gridlines.
  /// </summary>
  public static MinorGridlines? GetMinorGridlines(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
    if (itemElement != null)
      return MinorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinorGridlines(SeriesAxis? openXmlElement, MinorGridlines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorGridlinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Title.
  /// </summary>
  public static Title? GetTitle(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
    if (itemElement != null)
      return TitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTitle(SeriesAxis? openXmlElement, Title? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Title>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Number Format.
  /// </summary>
  public static NumberingFormat? GetNumberingFormat(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(SeriesAxis? openXmlElement, NumberingFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Major Tick Mark.
  /// </summary>
  public static TickMarkKind? GetMajorTickMark(SeriesAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MajorTickMark>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickMarkValues, TickMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMajorTickMark(SeriesAxis? openXmlElement, TickMarkKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MajorTickMark>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MajorTickMark, TickMarkValues, TickMarkKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Minor Tick Mark.
  /// </summary>
  public static TickMarkKind? GetMinorTickMark(SeriesAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MinorTickMark>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickMarkValues, TickMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMinorTickMark(SeriesAxis? openXmlElement, TickMarkKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MinorTickMark>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MinorTickMark, TickMarkValues, TickMarkKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Tick Label Position.
  /// </summary>
  public static TickLabelPositionKind? GetTickLabelPosition(SeriesAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TickLabelPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickLabelPositionValues, TickLabelPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTickLabelPosition(SeriesAxis? openXmlElement, TickLabelPositionKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TickLabelPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<TickLabelPosition, TickLabelPositionValues, TickLabelPositionKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  public static ChartShapeProperties? GetChartShapeProperties(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(SeriesAxis? openXmlElement, ChartShapeProperties? value)
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
  ///   TextProperties.
  /// </summary>
  public static TextProperties? GetTextProperties(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(SeriesAxis? openXmlElement, TextProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Crossing Axis ID.
  /// </summary>
  public static UInt32? GetCrossingAxis(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CrossingAxis>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCrossingAxis(SeriesAxis? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CrossingAxis>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new CrossingAxis { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CrossesKind? GetCrosses(SeriesAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Crosses>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<CrossesValues, CrossesKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetCrosses(SeriesAxis? openXmlElement, CrossesKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Crosses>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<Crosses, CrossesValues, CrossesKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Double? GetCrossesAt(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CrossesAt>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCrossesAt(SeriesAxis? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CrossesAt>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new CrossesAt { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetTickLabelSkip(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TickLabelSkip>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTickLabelSkip(SeriesAxis? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TickLabelSkip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TickLabelSkip { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Int32? GetTickMarkSkip(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TickMarkSkip>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTickMarkSkip(SeriesAxis? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TickMarkSkip>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new TickMarkSkip { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SerAxExtensionList? GetSerAxExtensionList(SeriesAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList>();
    if (itemElement != null)
      return SerAxExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSerAxExtensionList(SeriesAxis? openXmlElement, SerAxExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SerAxExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SerAxExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.SeriesAxis? CreateModelElement(SeriesAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SeriesAxis();
      value.AxisId = GetAxisId(openXmlElement);
      value.Scaling = GetScaling(openXmlElement);
      value.Delete = GetDelete(openXmlElement);
      value.AxisPosition = GetAxisPosition(openXmlElement);
      value.MajorGridlines = GetMajorGridlines(openXmlElement);
      value.MinorGridlines = GetMinorGridlines(openXmlElement);
      value.Title = GetTitle(openXmlElement);
      value.NumberingFormat = GetNumberingFormat(openXmlElement);
      value.MajorTickMark = GetMajorTickMark(openXmlElement);
      value.MinorTickMark = GetMinorTickMark(openXmlElement);
      value.TickLabelPosition = GetTickLabelPosition(openXmlElement);
      value.ChartShapeProperties = GetChartShapeProperties(openXmlElement);
      value.TextProperties = GetTextProperties(openXmlElement);
      value.CrossingAxis = GetCrossingAxis(openXmlElement);
      value.Crosses = GetCrosses(openXmlElement);
      value.CrossesAt = GetCrossesAt(openXmlElement);
      value.TickLabelSkip = GetTickLabelSkip(openXmlElement);
      value.TickMarkSkip = GetTickMarkSkip(openXmlElement);
      value.SerAxExtensionList = GetSerAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SeriesAxis? value)
    where OpenXmlElementType : SeriesAxis, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAxisId(openXmlElement, value?.AxisId);
      SetScaling(openXmlElement, value?.Scaling);
      SetDelete(openXmlElement, value?.Delete);
      SetAxisPosition(openXmlElement, value?.AxisPosition);
      SetMajorGridlines(openXmlElement, value?.MajorGridlines);
      SetMinorGridlines(openXmlElement, value?.MinorGridlines);
      SetTitle(openXmlElement, value?.Title);
      SetNumberingFormat(openXmlElement, value?.NumberingFormat);
      SetMajorTickMark(openXmlElement, value?.MajorTickMark);
      SetMinorTickMark(openXmlElement, value?.MinorTickMark);
      SetTickLabelPosition(openXmlElement, value?.TickLabelPosition);
      SetChartShapeProperties(openXmlElement, value?.ChartShapeProperties);
      SetTextProperties(openXmlElement, value?.TextProperties);
      SetCrossingAxis(openXmlElement, value?.CrossingAxis);
      SetCrosses(openXmlElement, value?.Crosses);
      SetCrossesAt(openXmlElement, value?.CrossesAt);
      SetTickLabelSkip(openXmlElement, value?.TickLabelSkip);
      SetTickMarkSkip(openXmlElement, value?.TickMarkSkip);
      SetSerAxExtensionList(openXmlElement, value?.SerAxExtensionList);
      return openXmlElement;
    }
    return default;
  }
}