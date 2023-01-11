namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// 3D Pie Charts.
/// </summary>
public static class Pie3DChartConverter
{
  /// <summary>
  /// VaryColors.
  /// </summary>
  public static Boolean? GetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.VaryColors>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetVaryColors(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? openXmlElement, Boolean? value)
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
  
  public static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries>? GetPieChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? openXmlElement)
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
  
  public static void SetPieChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.PieChartSeries>? value)
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
  
  public static DocumentModel.Drawings.Charts.DataLabels? GetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.DataLabels>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.DataLabelsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetDataLabels(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? openXmlElement, DocumentModel.Drawings.Charts.DataLabels? value)
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
  
  public static DocumentModel.Drawings.Charts.Pie3DChartExtensionList? GetPie3DChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.Pie3DChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetPie3DChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? openXmlElement, DocumentModel.Drawings.Charts.Pie3DChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentModel.OpenXml.Drawings.Charts.Pie3DChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.Pie3DChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.Charts.Pie3DChart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.Pie3DChart();
      value.VaryColors = GetVaryColors(openXmlElement);
      value.PieChartSerieses = GetPieChartSerieses(openXmlElement);
      value.DataLabels = GetDataLabels(openXmlElement);
      value.Pie3DChartExtensionList = GetPie3DChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.Pie3DChart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.Pie3DChart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
