using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using DisplayUnits = DocumentModel.Drawings.Charts.DisplayUnits;
using MajorGridlines = DocumentModel.Drawings.Charts.MajorGridlines;
using MinorGridlines = DocumentModel.Drawings.Charts.MinorGridlines;
using NumberingFormat = DocumentModel.Drawings.Charts.NumberingFormat;
using Scaling = DocumentModel.Drawings.Charts.Scaling;
using TextProperties = DocumentModel.Drawings.Charts.TextProperties;
using Title = DocumentModel.Drawings.Charts.Title;
using ValAxExtensionList = DocumentModel.Drawings.Charts.ValAxExtensionList;
using ValueAxis = DocumentFormat.OpenXml.Drawing.Charts.ValueAxis;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Value Axis.
/// </summary>
public static class ValueAxisConverter
{
  /// <summary>
  ///   Axis ID.
  /// </summary>
  public static UInt32? GetAxisId(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AxisId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAxisId(ValueAxis? openXmlElement, UInt32? value)
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
  public static Scaling? GetScaling(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
    if (itemElement != null)
      return ScalingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScaling(ValueAxis? openXmlElement, Scaling? value)
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
  public static Boolean? GetDelete(ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Delete>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDelete(ValueAxis? openXmlElement, Boolean? value)
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
  public static AxisPositionKind? GetAxisPosition(ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AxisPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<AxisPositionValues, AxisPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAxisPosition(ValueAxis? openXmlElement, AxisPositionKind? value)
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
  public static MajorGridlines? GetMajorGridlines(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
    if (itemElement != null)
      return MajorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMajorGridlines(ValueAxis? openXmlElement, MajorGridlines? value)
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
  public static MinorGridlines? GetMinorGridlines(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
    if (itemElement != null)
      return MinorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinorGridlines(ValueAxis? openXmlElement, MinorGridlines? value)
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
  public static Title? GetTitle(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
    if (itemElement != null)
      return TitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTitle(ValueAxis? openXmlElement, Title? value)
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
  public static NumberingFormat? GetNumberingFormat(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(ValueAxis? openXmlElement, NumberingFormat? value)
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
  public static TickMarkKind? GetMajorTickMark(ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MajorTickMark>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickMarkValues, TickMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMajorTickMark(ValueAxis? openXmlElement, TickMarkKind? value)
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
  public static TickMarkKind? GetMinorTickMark(ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MinorTickMark>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickMarkValues, TickMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMinorTickMark(ValueAxis? openXmlElement, TickMarkKind? value)
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
  public static TickLabelPositionKind? GetTickLabelPosition(ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TickLabelPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickLabelPositionValues, TickLabelPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTickLabelPosition(ValueAxis? openXmlElement, TickLabelPositionKind? value)
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
  public static ChartShapeProperties? GetChartShapeProperties(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(ValueAxis? openXmlElement, ChartShapeProperties? value)
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
  public static TextProperties? GetTextProperties(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(ValueAxis? openXmlElement, TextProperties? value)
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
  public static UInt32? GetCrossingAxis(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CrossingAxis>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCrossingAxis(ValueAxis? openXmlElement, UInt32? value)
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

  public static CrossesKind? GetCrosses(ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Crosses>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<CrossesValues, CrossesKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetCrosses(ValueAxis? openXmlElement, CrossesKind? value)
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

  public static Double? GetCrossesAt(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CrossesAt>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCrossesAt(ValueAxis? openXmlElement, Double? value)
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

  public static CrossBetweenKind? GetCrossBetween(ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CrossBetween>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<CrossBetweenValues, CrossBetweenKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetCrossBetween(ValueAxis? openXmlElement, CrossBetweenKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<CrossBetween>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<CrossBetween, CrossBetweenValues, CrossBetweenKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Double? GetMajorUnit(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MajorUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMajorUnit(ValueAxis? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MajorUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MajorUnit { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Double? GetMinorUnit(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MinorUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMinorUnit(ValueAxis? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MinorUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new MinorUnit { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DisplayUnits? GetDisplayUnits(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits>();
    if (itemElement != null)
      return DisplayUnitsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDisplayUnits(ValueAxis? openXmlElement, DisplayUnits? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DisplayUnitsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DisplayUnits>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ValAxExtensionList? GetValAxExtensionList(ValueAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList>();
    if (itemElement != null)
      return ValAxExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetValAxExtensionList(ValueAxis? openXmlElement, ValAxExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValAxExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ValAxExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.ValueAxis? CreateModelElement(ValueAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ValueAxis();
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
      value.CrossBetween = GetCrossBetween(openXmlElement);
      value.MajorUnit = GetMajorUnit(openXmlElement);
      value.MinorUnit = GetMinorUnit(openXmlElement);
      value.DisplayUnits = GetDisplayUnits(openXmlElement);
      value.ValAxExtensionList = GetValAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ValueAxis? value)
    where OpenXmlElementType : ValueAxis, new()
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
      SetCrossBetween(openXmlElement, value?.CrossBetween);
      SetMajorUnit(openXmlElement, value?.MajorUnit);
      SetMinorUnit(openXmlElement, value?.MinorUnit);
      SetDisplayUnits(openXmlElement, value?.DisplayUnits);
      SetValAxExtensionList(openXmlElement, value?.ValAxExtensionList);
      return openXmlElement;
    }
    return default;
  }
}