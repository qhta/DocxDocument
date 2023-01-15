using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentModel.Drawings.Charts;
using CatAxExtensionList = DocumentModel.Drawings.Charts.CatAxExtensionList;
using CategoryAxis = DocumentFormat.OpenXml.Drawing.Charts.CategoryAxis;
using ChartShapeProperties = DocumentModel.Drawings.Charts.ChartShapeProperties;
using MajorGridlines = DocumentModel.Drawings.Charts.MajorGridlines;
using MinorGridlines = DocumentModel.Drawings.Charts.MinorGridlines;
using NumberingFormat = DocumentModel.Drawings.Charts.NumberingFormat;
using Scaling = DocumentModel.Drawings.Charts.Scaling;
using TextProperties = DocumentModel.Drawings.Charts.TextProperties;
using Title = DocumentModel.Drawings.Charts.Title;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Category Axis Data.
/// </summary>
public static class CategoryAxisConverter
{
  /// <summary>
  ///   Axis ID.
  /// </summary>
  public static UInt32? GetAxisId(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<AxisId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetAxisId(CategoryAxis? openXmlElement, UInt32? value)
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
  public static Scaling? GetScaling(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Scaling>();
    if (itemElement != null)
      return ScalingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetScaling(CategoryAxis? openXmlElement, Scaling? value)
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
  public static Boolean? GetDelete(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Delete>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDelete(CategoryAxis? openXmlElement, Boolean? value)
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
  public static AxisPositionKind? GetAxisPosition(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AxisPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<AxisPositionValues, AxisPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetAxisPosition(CategoryAxis? openXmlElement, AxisPositionKind? value)
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
  public static MajorGridlines? GetMajorGridlines(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MajorGridlines>();
    if (itemElement != null)
      return MajorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMajorGridlines(CategoryAxis? openXmlElement, MajorGridlines? value)
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
  public static MinorGridlines? GetMinorGridlines(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.MinorGridlines>();
    if (itemElement != null)
      return MinorGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinorGridlines(CategoryAxis? openXmlElement, MinorGridlines? value)
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
  public static Title? GetTitle(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Title>();
    if (itemElement != null)
      return TitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTitle(CategoryAxis? openXmlElement, Title? value)
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
  public static NumberingFormat? GetNumberingFormat(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat>();
    if (itemElement != null)
      return NumberingFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberingFormat(CategoryAxis? openXmlElement, NumberingFormat? value)
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
  public static TickMarkKind? GetMajorTickMark(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MajorTickMark>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickMarkValues, TickMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMajorTickMark(CategoryAxis? openXmlElement, TickMarkKind? value)
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
  public static TickMarkKind? GetMinorTickMark(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<MinorTickMark>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickMarkValues, TickMarkKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetMinorTickMark(CategoryAxis? openXmlElement, TickMarkKind? value)
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
  public static TickLabelPositionKind? GetTickLabelPosition(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<TickLabelPosition>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<TickLabelPositionValues, TickLabelPositionKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetTickLabelPosition(CategoryAxis? openXmlElement, TickLabelPositionKind? value)
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
  public static ChartShapeProperties? GetChartShapeProperties(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ChartShapeProperties>();
    if (itemElement != null)
      return ChartShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetChartShapeProperties(CategoryAxis? openXmlElement, ChartShapeProperties? value)
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
  public static TextProperties? GetTextProperties(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.TextProperties>();
    if (itemElement != null)
      return TextPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTextProperties(CategoryAxis? openXmlElement, TextProperties? value)
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
  public static UInt32? GetCrossingAxis(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CrossingAxis>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCrossingAxis(CategoryAxis? openXmlElement, UInt32? value)
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

  public static CrossesKind? GetCrosses(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Crosses>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<CrossesValues, CrossesKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetCrosses(CategoryAxis? openXmlElement, CrossesKind? value)
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

  public static Double? GetCrossesAt(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<CrossesAt>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetCrossesAt(CategoryAxis? openXmlElement, Double? value)
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

  public static Boolean? GetAutoLabeled(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<AutoLabeled>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetAutoLabeled(CategoryAxis? openXmlElement, Boolean? value)
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

  public static LabelAlignmentKind? GetLabelAlignment(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LabelAlignment>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<LabelAlignmentValues, LabelAlignmentKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetLabelAlignment(CategoryAxis? openXmlElement, LabelAlignmentKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<LabelAlignment>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<LabelAlignment, LabelAlignmentValues, LabelAlignmentKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt16? GetLabelOffset(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<LabelOffset>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetLabelOffset(CategoryAxis? openXmlElement, UInt16? value)
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

  public static Int32? GetTickLabelSkip(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TickLabelSkip>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTickLabelSkip(CategoryAxis? openXmlElement, Int32? value)
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

  public static Int32? GetTickMarkSkip(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<TickMarkSkip>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetTickMarkSkip(CategoryAxis? openXmlElement, Int32? value)
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

  public static Boolean? GetNoMultiLevelLabels(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<NoMultiLevelLabels>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetNoMultiLevelLabels(CategoryAxis? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<NoMultiLevelLabels>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new NoMultiLevelLabels();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static CatAxExtensionList? GetCatAxExtensionList(CategoryAxis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList>();
    if (itemElement != null)
      return CatAxExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCatAxExtensionList(CategoryAxis? openXmlElement, CatAxExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CatAxExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.CatAxExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.CategoryAxis? CreateModelElement(CategoryAxis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.CategoryAxis();
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
      value.LabelAlignment = GetLabelAlignment(openXmlElement);
      value.LabelOffset = GetLabelOffset(openXmlElement);
      value.TickLabelSkip = GetTickLabelSkip(openXmlElement);
      value.TickMarkSkip = GetTickMarkSkip(openXmlElement);
      value.NoMultiLevelLabels = GetNoMultiLevelLabels(openXmlElement);
      value.CatAxExtensionList = GetCatAxExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.CategoryAxis? value)
    where OpenXmlElementType : CategoryAxis, new()
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
      SetLabelAlignment(openXmlElement, value?.LabelAlignment);
      SetLabelOffset(openXmlElement, value?.LabelOffset);
      SetTickLabelSkip(openXmlElement, value?.TickLabelSkip);
      SetTickMarkSkip(openXmlElement, value?.TickMarkSkip);
      SetNoMultiLevelLabels(openXmlElement, value?.NoMultiLevelLabels);
      SetCatAxExtensionList(openXmlElement, value?.CatAxExtensionList);
      return openXmlElement;
    }
    return default;
  }
}