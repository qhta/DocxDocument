namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Pie Charts.
/// </summary>
public static class PieChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement, Boolean? value)
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
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries>? GetPieChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>())
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.PieChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static void SetPieChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>();
      if (value != null)
      {
        foreach (var item in value)
        {
          var newItem = DocumentModel.OpenXml.Drawings.Charts.PieChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
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
  
  public static UInt16? GetFirstSliceAngle(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FirstSliceAngle");
  }
  
  public static void SetFirstSliceAngle(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement, UInt16? value)
  {
    throw new NotImplementedException("Not implemented in GenerateSimplePropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.Charts.FirstSliceAngle");
  }
  
  public static DocumentModel.Drawings.Charts.PieChartExtensionList? GetPieChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.PieChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPieChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement, DocumentModel.Drawings.Charts.PieChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.PieChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.PieChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.PieChart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.PieChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PieChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSerieses = GetPieChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.FirstSliceAngle = GetFirstSliceAngle(openXmlElement);
      value.PieChartExtensionList = GetPieChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PieChart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.PieChart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
