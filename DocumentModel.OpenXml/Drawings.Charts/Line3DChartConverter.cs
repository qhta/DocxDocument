namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Line Charts.
/// </summary>
public static class Line3DChartConverter
{
  /// <summary>
  /// Grouping.
  /// </summary>
  private static DocumentModel.Drawings.Charts.GroupingKind? GetGrouping(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Grouping>();
    if (itemElement?.Val?.Value != null)
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DocumentModel.Drawings.Charts.GroupingKind>(itemElement.Val.Value);
    return null;
  }
  
  private static void SetGrouping(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement, DocumentModel.Drawings.Charts.GroupingKind? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Grouping>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Grouping, DocumentFormat.OpenXml.Drawing.Charts.GroupingValues, DocumentModel.Drawings.Charts.GroupingKind>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  private static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
    return itemElement != null;
  }
  
  private static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.VaryColors();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartSeries> GetLineChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartSeries>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.LineChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetLineChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.LineChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.LineChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.LineChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static DocumentModel.Drawings.Charts.DropLines? GetDropLines(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DropLines>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DropLinesConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetDropLines(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement, DocumentModel.Drawings.Charts.DropLines? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DropLines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.DropLinesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.DropLines>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static UInt16? GetGapDepth(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapDepth>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  private static void SetGapDepth(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement, UInt16? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.GapDepth>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DocumentFormat.OpenXml.Drawing.Charts.GapDepth{ Val = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<UInt32> GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<UInt32>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.AxisId>())
    {
      var newItem = UInt32ValueConverter.GetValue(item);
      if (newItem != null)
        collection.Add((UInt32)newItem);
    }
    return collection;
  }
  
  private static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.AxisId>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = UInt32ValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.AxisId>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.Line3DChartExtensionList? GetLine3DChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Line3DChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetLine3DChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart openXmlElement, DocumentModel.Drawings.Charts.Line3DChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.Line3DChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Line3DChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.Line3DChart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Line3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Line3DChart();
      value.Grouping = GetGrouping(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.LineChartSerieses = GetLineChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.DropLines = GetDropLines(openXmlElement);
      value.GapDepth = GetGapDepth(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.Line3DChartExtensionList = GetLine3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Line3DChart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Line3DChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetGrouping(openXmlElement, value?.Grouping);
      SetVaryColors(openXmlElement, value?.VaryColors);
      SetLineChartSerieses(openXmlElement, value?.LineChartSerieses);
      SetDataLabels(openXmlElement, value?.DataLabels);
      SetDropLines(openXmlElement, value?.DropLines);
      SetGapDepth(openXmlElement, value?.GapDepth);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetLine3DChartExtensionList(openXmlElement, value?.Line3DChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
