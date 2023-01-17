namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Series Class.
/// </summary>
public static class SeriesConverter
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.SeriesLayout? GetLayoutId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DocumentModel.Drawings.ChartDrawings.SeriesLayout>(openXmlElement?.LayoutId?.Value);
  }
  
  private static void SetLayoutId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, DocumentModel.Drawings.ChartDrawings.SeriesLayout? value)
  {
    openXmlElement.LayoutId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DocumentModel.Drawings.ChartDrawings.SeriesLayout>(value);
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  private static Boolean? GetHidden(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  private static void SetHidden(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
    else
      openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetOwnerIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    return openXmlElement.OwnerIdx?.Value;
  }
  
  private static void SetOwnerIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, UInt32? value)
  {
    openXmlElement.OwnerIdx = value;
  }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  private static String? GetUniqueId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }
  
  private static void SetUniqueId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.UniqueId = new StringValue { Value = value };
    else
      openXmlElement.UniqueId = null;
  }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetFormatIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    return openXmlElement.FormatIdx?.Value;
  }
  
  private static void SetFormatIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, UInt32? value)
  {
    openXmlElement.FormatIdx = value;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.Text? GetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, DocumentModel.Drawings.ChartDrawings.Text? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.TextConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ValueColors? GetValueColors(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ValueColorsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetValueColors(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, DocumentModel.Drawings.ChartDrawings.ValueColors? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ValueColorsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  private static DocumentModel.Drawings.ChartDrawings.ValueColorPositions? GetValueColorPositions(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ValueColorPositionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetValueColorPositions(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, DocumentModel.Drawings.ChartDrawings.ValueColorPositions? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ValueColorPositionsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataPoint> GetDataPoints(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataPoint>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.DataPointConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetDataPoints(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataPoint>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.ChartDrawings.DataPointConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataPoint>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawings.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, DocumentModel.Drawings.ChartDrawings.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.DataLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt32? GetDataId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetDataId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, UInt32? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? GetSeriesLayoutProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.SeriesLayoutPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSeriesLayoutProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.SeriesLayoutPropertiesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<String> GetAxisIds(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<String>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId>())
    {
      var newItem = StringValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((string)newItem);
    }
    return collection;
  }
  
  private static void SetAxisIds(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, System.Collections.ObjectModel.Collection<String>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = StringValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.AxisId>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.Series? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series, new()
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
