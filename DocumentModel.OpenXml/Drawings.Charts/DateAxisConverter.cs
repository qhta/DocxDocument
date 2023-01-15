using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using DateAxExtensionList = DocumentModel.Drawings.Charts.DateAxExtensionList;
using DateAxis = DocumentFormat.OpenXml.Drawing.Charts.DateAxis;
using MajorGridlines = DocumentModel.Drawings.Charts.MajorGridlines;
using MinorGridlines = DocumentModel.Drawings.Charts.MinorGridlines;
using NumberingFormat = DocumentModel.Drawings.Charts.NumberingFormat;
using Scaling = DocumentModel.Drawings.Charts.Scaling;
using TextProperties = DocumentModel.Drawings.Charts.TextProperties;
using Title = DocumentModel.Drawings.Charts.Title;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Date Axis.
/// </summary>
public static class DateAxisConverter
{
  /// <summary>
  ///   Axis ID.
  /// </summary>
  public static UInt32? GetAxisId(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AxisId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAxisId(DateAxis? openXmlElement, UInt32? value)
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
  public static Scaling? GetScaling(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
    if (itemElement != null)
      return ScalingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScaling(DateAxis? openXmlElement, Scaling? value)
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
  public static Boolean? GetDelete(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Delete>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDelete(DateAxis? openXmlElement, Boolean? value)
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
  public static AxisPositionKind? GetAxisPosition(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AxisPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<AxisPositionValues, AxisPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAxisPosition(DateAxis? openXmlElement, AxisPositionKind? value)
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
  public static MajorGridlines? GetMajorGridlines(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
    if (itemElement != null)
      return MajorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMajorGridlines(DateAxis? openXmlElement, MajorGridlines? value)
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
  public static MinorGridlines? GetMinorGridlines(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
    if (itemElement != null)
      return MinorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinorGridlines(DateAxis? openXmlElement, MinorGridlines? value)
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
  public static Title? GetTitle(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
    if (itemElement != null)
      return TitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTitle(DateAxis? openXmlElement, Title? value)
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
  public static NumberingFormat? GetNumberingFormat(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(DateAxis? openXmlElement, NumberingFormat? value)
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
  public static TickMarkKind? GetMajorTickMark(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MajorTickMark>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickMarkValues, TickMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMajorTickMark(DateAxis? openXmlElement, TickMarkKind? value)
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
  public static TickMarkKind? GetMinorTickMark(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MinorTickMark>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickMarkValues, TickMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMinorTickMark(DateAxis? openXmlElement, TickMarkKind? value)
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
  public static TickLabelPositionKind? GetTickLabelPosition(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TickLabelPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickLabelPositionValues, TickLabelPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTickLabelPosition(DateAxis? openXmlElement, TickLabelPositionKind? value)
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
  public static ChartShapeProperties? GetChartShapeProperties(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(DateAxis? openXmlElement, ChartShapeProperties? value)
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
  public static TextProperties? GetTextProperties(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(DateAxis? openXmlElement, TextProperties? value)
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
  public static UInt32? GetCrossingAxis(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CrossingAxis>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCrossingAxis(DateAxis? openXmlElement, UInt32? value)
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

  public static CrossesKind? GetCrosses(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Crosses>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<CrossesValues, CrossesKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetCrosses(DateAxis? openXmlElement, CrossesKind? value)
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

  public static Double? GetCrossesAt(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CrossesAt>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCrossesAt(DateAxis? openXmlElement, Double? value)
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

  public static Boolean? GetAutoLabeled(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoLabeled>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoLabeled(DateAxis? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<AutoLabeled>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new AutoLabeled();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt16? GetLabelOffset(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LabelOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLabelOffset(DateAxis? openXmlElement, UInt16? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LabelOffset>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new LabelOffset { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TimeUnitKind? GetBaseTimeUnit(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BaseTimeUnit>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TimeUnitValues, TimeUnitKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetBaseTimeUnit(DateAxis? openXmlElement, TimeUnitKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<BaseTimeUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<BaseTimeUnit, TimeUnitValues, TimeUnitKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Double? GetMajorUnit(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MajorUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMajorUnit(DateAxis? openXmlElement, Double? value)
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

  public static TimeUnitKind? GetMajorTimeUnit(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MajorTimeUnit>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TimeUnitValues, TimeUnitKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMajorTimeUnit(DateAxis? openXmlElement, TimeUnitKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MajorTimeUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MajorTimeUnit, TimeUnitValues, TimeUnitKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Double? GetMinorUnit(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<MinorUnit>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetMinorUnit(DateAxis? openXmlElement, Double? value)
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

  public static TimeUnitKind? GetMinorTimeUnit(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MinorTimeUnit>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TimeUnitValues, TimeUnitKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMinorTimeUnit(DateAxis? openXmlElement, TimeUnitKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MinorTimeUnit>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<MinorTimeUnit, TimeUnitValues, TimeUnitKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DateAxExtensionList? GetDateAxExtensionList(DateAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList>();
    if (itemElement != null)
      return DateAxExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDateAxExtensionList(DateAxis? openXmlElement, DateAxExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DateAxExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DateAxExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.DateAxis? CreateModelElement(DateAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.DateAxis();
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
      value.AutoLabeled = GetAutoLabeled(openXmlElement);
      value.LabelOffset = GetLabelOffset(openXmlElement);
      value.BaseTimeUnit = GetBaseTimeUnit(openXmlElement);
      value.MajorUnit = GetMajorUnit(openXmlElement);
      value.MajorTimeUnit = GetMajorTimeUnit(openXmlElement);
      value.MinorUnit = GetMinorUnit(openXmlElement);
      value.MinorTimeUnit = GetMinorTimeUnit(openXmlElement);
      value.DateAxExtensionList = GetDateAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.DateAxis? value)
    where OpenXmlElementType : DateAxis, new()
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
      SetAutoLabeled(openXmlElement, value?.AutoLabeled);
      SetLabelOffset(openXmlElement, value?.LabelOffset);
      SetBaseTimeUnit(openXmlElement, value?.BaseTimeUnit);
      SetMajorUnit(openXmlElement, value?.MajorUnit);
      SetMajorTimeUnit(openXmlElement, value?.MajorTimeUnit);
      SetMinorUnit(openXmlElement, value?.MinorUnit);
      SetMinorTimeUnit(openXmlElement, value?.MinorTimeUnit);
      SetDateAxExtensionList(openXmlElement, value?.DateAxExtensionList);
      return openXmlElement;
    }
    return default;
  }
}