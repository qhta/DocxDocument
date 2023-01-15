using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using AxisTitle = DocumentModel.Drawings.ChartDrawings.AxisTitle;
using AxisUnits = DocumentModel.Drawings.ChartDrawings.AxisUnits;
using CategoryAxisScaling = DocumentModel.Drawings.ChartDrawings.CategoryAxisScaling;
using MajorGridlinesGridlines = DocumentModel.Drawings.ChartDrawings.MajorGridlinesGridlines;
using MajorTickMarksTickMarks = DocumentModel.Drawings.ChartDrawings.MajorTickMarksTickMarks;
using MinorGridlinesGridlines = DocumentModel.Drawings.ChartDrawings.MinorGridlinesGridlines;
using MinorTickMarksTickMarks = DocumentModel.Drawings.ChartDrawings.MinorTickMarksTickMarks;
using NumberFormat = DocumentModel.Drawings.ChartDrawings.NumberFormat;
using ShapeProperties = DocumentModel.Drawings.ChartDrawings.ShapeProperties;
using TickLabels = DocumentModel.Drawings.ChartDrawings.TickLabels;
using TxPrTextBody = DocumentModel.Drawings.ChartDrawings.TxPrTextBody;
using ValueAxisScaling = DocumentModel.Drawings.ChartDrawings.ValueAxisScaling;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Axis Class.
/// </summary>
public static class AxisConverter
{
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetId(Axis? openXmlElement)
  {
    return openXmlElement?.Id?.Value;
  }

  public static void SetId(Axis? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Id = value;
  }

  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetHidden(Axis? openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }

  public static void SetHidden(Axis? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Hidden = null;
  }

  public static CategoryAxisScaling? GetCategoryAxisScaling(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling>();
    if (itemElement != null)
      return CategoryAxisScalingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetCategoryAxisScaling(Axis? openXmlElement, CategoryAxisScaling? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryAxisScalingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.CategoryAxisScaling>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ValueAxisScaling? GetValueAxisScaling(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling>();
    if (itemElement != null)
      return ValueAxisScalingConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetValueAxisScaling(Axis? openXmlElement, ValueAxisScaling? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueAxisScalingConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueAxisScaling>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AxisTitle? GetAxisTitle(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle>();
    if (itemElement != null)
      return AxisTitleConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAxisTitle(Axis? openXmlElement, AxisTitle? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisTitleConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisTitle>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static AxisUnits? GetAxisUnits(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits>();
    if (itemElement != null)
      return AxisUnitsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetAxisUnits(Axis? openXmlElement, AxisUnits? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisUnitsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisUnits>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MajorGridlinesGridlines? GetMajorGridlinesGridlines(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines>();
    if (itemElement != null)
      return MajorGridlinesGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMajorGridlinesGridlines(Axis? openXmlElement, MajorGridlinesGridlines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorGridlinesGridlinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorGridlinesGridlines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MinorGridlinesGridlines? GetMinorGridlinesGridlines(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines>();
    if (itemElement != null)
      return MinorGridlinesGridlinesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinorGridlinesGridlines(Axis? openXmlElement, MinorGridlinesGridlines? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorGridlinesGridlinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorGridlinesGridlines>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MajorTickMarksTickMarks? GetMajorTickMarksTickMarks(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks>();
    if (itemElement != null)
      return MajorTickMarksTickMarksConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMajorTickMarksTickMarks(Axis? openXmlElement, MajorTickMarksTickMarks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorTickMarksTickMarksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MajorTickMarksTickMarks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static MinorTickMarksTickMarks? GetMinorTickMarksTickMarks(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks>();
    if (itemElement != null)
      return MinorTickMarksTickMarksConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetMinorTickMarksTickMarks(Axis? openXmlElement, MinorTickMarksTickMarks? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorTickMarksTickMarksConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.MinorTickMarksTickMarks>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static TickLabels? GetTickLabels(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels>();
    if (itemElement != null)
      return TickLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTickLabels(Axis? openXmlElement, TickLabels? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TickLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TickLabels>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static NumberFormat? GetNumberFormat(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
    if (itemElement != null)
      return NumberFormatConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetNumberFormat(Axis? openXmlElement, NumberFormat? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberFormatConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberFormat>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static ShapeProperties? GetShapeProperties(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(Axis? openXmlElement, ShapeProperties? value)
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

  public static TxPrTextBody? GetTxPrTextBody(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.TxPrTextBody>();
    if (itemElement != null)
      return TxPrTextBodyConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetTxPrTextBody(Axis? openXmlElement, TxPrTextBody? value)
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

  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(Axis? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Axis? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.ChartDrawings.Axis? CreateModelElement(Axis? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Axis();
      value.Id = GetId(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.CategoryAxisScaling = GetCategoryAxisScaling(openXmlElement);
      value.ValueAxisScaling = GetValueAxisScaling(openXmlElement);
      value.AxisTitle = GetAxisTitle(openXmlElement);
      value.AxisUnits = GetAxisUnits(openXmlElement);
      value.MajorGridlinesGridlines = GetMajorGridlinesGridlines(openXmlElement);
      value.MinorGridlinesGridlines = GetMinorGridlinesGridlines(openXmlElement);
      value.MajorTickMarksTickMarks = GetMajorTickMarksTickMarks(openXmlElement);
      value.MinorTickMarksTickMarks = GetMinorTickMarksTickMarks(openXmlElement);
      value.TickLabels = GetTickLabels(openXmlElement);
      value.NumberFormat = GetNumberFormat(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.TxPrTextBody = GetTxPrTextBody(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Axis? value)
    where OpenXmlElementType : Axis, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetId(openXmlElement, value?.Id);
      SetHidden(openXmlElement, value?.Hidden);
      SetCategoryAxisScaling(openXmlElement, value?.CategoryAxisScaling);
      SetValueAxisScaling(openXmlElement, value?.ValueAxisScaling);
      SetAxisTitle(openXmlElement, value?.AxisTitle);
      SetAxisUnits(openXmlElement, value?.AxisUnits);
      SetMajorGridlinesGridlines(openXmlElement, value?.MajorGridlinesGridlines);
      SetMinorGridlinesGridlines(openXmlElement, value?.MinorGridlinesGridlines);
      SetMajorTickMarksTickMarks(openXmlElement, value?.MajorTickMarksTickMarks);
      SetMinorTickMarksTickMarks(openXmlElement, value?.MinorTickMarksTickMarks);
      SetTickLabels(openXmlElement, value?.TickLabels);
      SetNumberFormat(openXmlElement, value?.NumberFormat);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetTxPrTextBody(openXmlElement, value?.TxPrTextBody);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}