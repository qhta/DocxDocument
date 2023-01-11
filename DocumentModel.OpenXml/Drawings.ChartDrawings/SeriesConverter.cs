namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the Series Class.
/// </summary>
public static class SeriesConverter
{
  /// <summary>
  /// layoutId, this property is only available in Office 2016 and later.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.SeriesLayout? GetLayoutId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DocumentModel.Drawings.ChartDrawings.SeriesLayout>(openXmlElement?.LayoutId?.Value);
  }
  
  public static void SetLayoutId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.SeriesLayout? value)
  {
    if (openXmlElement != null)
      openXmlElement.LayoutId = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayout, DocumentModel.Drawings.ChartDrawings.SeriesLayout>(value);
  }
  
  /// <summary>
  /// hidden, this property is only available in Office 2016 and later.
  /// </summary>
  public static Boolean? GetHidden(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    return openXmlElement?.Hidden?.Value;
  }
  
  public static void SetHidden(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        openXmlElement.Hidden = null;
  }
  
  /// <summary>
  /// ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetOwnerIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    return openXmlElement?.OwnerIdx?.Value;
  }
  
  public static void SetOwnerIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.OwnerIdx = value;
  }
  
  /// <summary>
  /// uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  public static String? GetUniqueId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    return openXmlElement?.UniqueId?.Value;
  }
  
  public static void SetUniqueId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, String? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.UniqueId = new StringValue { Value = value };
      else
        openXmlElement.UniqueId = null;
  }
  
  /// <summary>
  /// formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  public static UInt32? GetFormatIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    return openXmlElement?.FormatIdx?.Value;
  }
  
  public static void SetFormatIdx(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, UInt32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FormatIdx = value;
  }
  
  /// <summary>
  /// Text.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.Text? GetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Text>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.TextConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetText(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.Text? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ShapeProperties? GetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ShapeProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ShapePropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetShapeProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.ShapeProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ValueColors.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ValueColors? GetValueColors(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColors>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ValueColorsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetValueColors(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.ValueColors? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// ValueColorPositions.
  /// </summary>
  public static DocumentModel.Drawings.ChartDrawings.ValueColorPositions? GetValueColorPositions(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorPositions>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ValueColorPositionsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetValueColorPositions(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.ValueColorPositions? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataPoint>? GetDataPoints(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetDataPoints(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.ChartDrawings.DataPoint>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawings.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.DataLabels? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static UInt32? GetDataId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId");
  }
  
  public static void SetDataId(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, UInt32? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.DataId");
  }
  
  public static DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? GetSeriesLayoutProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.SeriesLayoutProperties>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.SeriesLayoutPropertiesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetSeriesLayoutProperties(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.SeriesLayoutProperties? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<String>? GetAxisIds(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, System.Collections.ObjectModel.Collection<String>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ExtensionList? GetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ChartDrawings.ExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetExtensionList(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.Series? openXmlElement, DocumentModel.Drawings.ChartDrawings.ExtensionList? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
