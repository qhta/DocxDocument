namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Scatter Charts.
/// </summary>
public static class ScatterChartConverter
{
  /// <summary>
  /// ScatterStyle.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ScatterStyleKind? GetScatterStyle(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle>();
      if (itemElement?.Val?.Value != null)
      {
        return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DocumentModel.Drawings.Charts.ScatterStyleKind>(itemElement.Val.Value);
      }
    }
    return null;
  }
  
  public static void SetScatterStyle(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, DocumentModel.Drawings.Charts.ScatterStyleKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterStyle, DocumentFormat.OpenXml.Drawing.Charts.ScatterStyleValues, DocumentModel.Drawings.Charts.ScatterStyleKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ScatterChartSeries>? GetScatterChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ScatterChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.ScatterChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetScatterChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.ScatterChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.ScatterChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static System.Collections.ObjectModel.Collection<UInt32>? GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
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
    return null;
  }
  
  public static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
  {
    if (openXmlElement != null)
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
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChartExtensionList? GetScatterChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.ScatterChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetScatterChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement, DocumentModel.Drawings.Charts.ScatterChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.ScatterChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ScatterChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.ScatterChart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.ScatterChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.ScatterChart();
      value.ScatterStyle = GetScatterStyle(openXmlElement);
      value.VaryColors = GetVaryColors(openXmlElement);
      value.ScatterChartSerieses = GetScatterChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.ScatterChartExtensionList = GetScatterChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.ScatterChart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.ScatterChart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
