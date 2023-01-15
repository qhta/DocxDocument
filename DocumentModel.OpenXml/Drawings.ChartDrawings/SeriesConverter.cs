using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DataLabels = DocumentModel.Drawings.ChartDrawings.DataLabels;
using DataPoint = DocumentModel.Drawings.ChartDrawings.DataPoint;
using Series = DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series;
using SeriesLayout = DocumentModel.Drawings.ChartDrawings.SeriesLayout;
using SeriesLayoutProperties = DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties;
using ShapeProperties = DocumentModel.Drawings.ChartDrawings.ShapeProperties;
using Text = DocumentModel.Drawings.ChartDrawings.Text;
using ValueColorPositions = DocumentModel.Drawings.ChartDrawings.ValueColorPositions;
using ValueColors = DocumentModel.Drawings.ChartDrawings.ValueColors;

namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
///   Defines the Series Class.
/// </summary>
public static class SeriesConverter
{
  /// <summary>
  ///   layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public static SeriesLayout? GetLayoutId(Series? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, SeriesLayout>(openXmlElement?.LayoutId?.Value);
  }

  public static void SetLayoutId(Series? openXmlElement, SeriesLayout? value)
  {
    if (openXmlElement != null)
      openXmlElement.LayoutId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, SeriesLayout>(value);
  }

  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetHidden(Series? openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }

  public static void SetHidden(Series? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Hidden = null;
  }

  /// <summary>
  ///   ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetOwnerIdx(Series? openXmlElement)
  {
    return openXmlElement?.OwnerIdx?.Value;
  }

  public static void SetOwnerIdx(Series? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.OwnerIdx = value;
  }

  /// <summary>
  ///   uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetUniqueId(Series? openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }

  public static void SetUniqueId(Series? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UniqueId = new StringValue { Value = value };
      else
        openXmlElement.UniqueId = null;
  }

  /// <summary>
  ///   formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetFormatIdx(Series? openXmlElement)
  {
    return openXmlElement?.FormatIdx?.Value;
  }

  public static void SetFormatIdx(Series? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FormatIdx = value;
  }

  /// <summary>
  ///   Text.
  /// </summary>
  public static Text? GetText(Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
    if (itemElement != null)
      return TextConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetText(Series? openXmlElement, Text? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  public static ShapeProperties? GetShapeProperties(Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetShapeProperties(Series? openXmlElement, ShapeProperties? value)
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
  ///   ValueColors.
  /// </summary>
  public static ValueColors? GetValueColors(Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors>();
    if (itemElement != null)
      return ValueColorsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetValueColors(Series? openXmlElement, ValueColors? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueColorsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   ValueColorPositions.
  /// </summary>
  public static ValueColorPositions? GetValueColorPositions(Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>();
    if (itemElement != null)
      return ValueColorPositionsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetValueColorPositions(Series? openXmlElement, ValueColorPositions? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueColorPositionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<DataPoint>? GetDataPoints(Series? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<DataPoint>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>())
      {
        var newItem = DataPointConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetDataPoints(Series? openXmlElement, Collection<DataPoint>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = DataPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DataLabels? GetDataLabels(Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>();
    if (itemElement != null)
      return DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetDataLabels(Series? openXmlElement, DataLabels? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static UInt32? GetDataId(Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DataId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetDataId(Series? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DataId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DataId { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static SeriesLayoutProperties? GetSeriesLayoutProperties(Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>();
    if (itemElement != null)
      return SeriesLayoutPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSeriesLayoutProperties(Series? openXmlElement, SeriesLayoutProperties? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesLayoutPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<String>? GetAxisIds(Series? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<String>();
      foreach (var item in openXmlElement.Elements<AxisId>())
      {
        var newItem = StringValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((string)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAxisIds(Series? openXmlElement, Collection<String>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<AxisId>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = StringValueConverter.CreateOpenXmlElement<AxisId>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetExtensionList(Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
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

  public static DocumentModel.Drawings.ChartDrawings.Series? CreateModelElement(Series? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.Series();
      value.LayoutId = GetLayoutId(openXmlElement);
      value.Hidden = GetHidden(openXmlElement);
      value.OwnerIdx = GetOwnerIdx(openXmlElement);
      value.UniqueId = GetUniqueId(openXmlElement);
      value.FormatIdx = GetFormatIdx(openXmlElement);
      value.Text = GetText(openXmlElement);
      value.ShapeProperties = GetShapeProperties(openXmlElement);
      value.ValueColors = GetValueColors(openXmlElement);
      value.ValueColorPositions = GetValueColorPositions(openXmlElement);
      value.DataPoints = GetDataPoints(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DataId = GetDataId(openXmlElement);
      value.SeriesLayoutProperties = GetSeriesLayoutProperties(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.ExtensionList = GetExtensionList(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.Series? value)
    where OpenXmlElementType : Series, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLayoutId(openXmlElement, value?.LayoutId);
      SetHidden(openXmlElement, value?.Hidden);
      SetOwnerIdx(openXmlElement, value?.OwnerIdx);
      SetUniqueId(openXmlElement, value?.UniqueId);
      SetFormatIdx(openXmlElement, value?.FormatIdx);
      SetText(openXmlElement, value?.Text);
      SetShapeProperties(openXmlElement, value?.ShapeProperties);
      SetValueColors(openXmlElement, value?.ValueColors);
      SetValueColorPositions(openXmlElement, value?.ValueColorPositions);
      SetDataPoints(openXmlElement, value?.DataPoints);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDataId(openXmlElement, value?.DataId);
      SetSeriesLayoutProperties(openXmlElement, value?.SeriesLayoutProperties);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetExtensionList(openXmlElement, value?.ExtensionList);
      return openXmlElement;
    }
    return default;
  }
}