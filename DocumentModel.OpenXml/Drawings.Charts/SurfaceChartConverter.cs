namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Surface Charts.
/// </summary>
public static class SurfaceChartConverter
{
  /// <summary>
  /// Wireframe.
  /// </summary>
  private static Boolean? GetWireframe(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Wireframe>();
    return itemElement != null;
  }
  
  private static void SetWireframe(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.Wireframe>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Drawing.Charts.Wireframe();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SurfaceChartSeries> GetSurfaceChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement)
  {
    var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SurfaceChartSeries>();
    foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>())
    {
      var newItem = DocumentModel.OpenXml.Drawings.Charts.SurfaceChartSeriesConverter.CreateModelElement(item);
      if (newItem != null)
        collection.Add(newItem);
    }
    return collection;
  }
  
  private static void SetSurfaceChartSerieses(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement, System.Collections.ObjectModel.Collection<DocumentModel.Drawings.Charts.SurfaceChartSeries>? value)
  {
    openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>();
    if (value != null)
    {
      foreach (var item in value)
      {
        var newItem = DocumentModel.OpenXml.Drawings.Charts.SurfaceChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>(item);
        if (newItem != null)
          openXmlElement.AddChild(newItem);
      }
    }
  }
  
  private static DocumentModel.Drawings.Charts.BandFormats? GetBandFormats(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BandFormats>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.BandFormatsConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBandFormats(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement, DocumentModel.Drawings.Charts.BandFormats? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BandFormats>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.BandFormatsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BandFormats>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  private static System.Collections.ObjectModel.Collection<UInt32> GetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement)
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
  
  private static void SetAxisIds(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement, System.Collections.ObjectModel.Collection<UInt32>? value)
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
  
  private static DocumentModel.Drawings.Charts.SurfaceChartExtensionList? GetSurfaceChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.Charts.SurfaceChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetSurfaceChartExtensionList(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart openXmlElement, DocumentModel.Drawings.Charts.SurfaceChartExtensionList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.Charts.SurfaceChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.SurfaceChart? CreateModelElement(DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.SurfaceChart();
      value.Wireframe = GetWireframe(openXmlElement);
      value.SurfaceChartSerieses = GetSurfaceChartSerieses(openXmlElement);
      value.BandFormats = GetBandFormats(openXmlElement);
      value.AxisIds = GetAxisIds(openXmlElement);
      value.SurfaceChartExtensionList = GetSurfaceChartExtensionList(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.SurfaceChart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Charts.SurfaceChart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetWireframe(openXmlElement, value?.Wireframe);
      SetSurfaceChartSerieses(openXmlElement, value?.SurfaceChartSerieses);
      SetBandFormats(openXmlElement, value?.BandFormats);
      SetAxisIds(openXmlElement, value?.AxisIds);
      SetSurfaceChartExtensionList(openXmlElement, value?.SurfaceChartExtensionList);
      return openXmlElement;
    }
    return default;
  }
}
