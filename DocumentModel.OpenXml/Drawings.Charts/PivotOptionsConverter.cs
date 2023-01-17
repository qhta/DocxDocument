namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public static class PivotOptionsConverter
{
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  private static Boolean? GetDropZoneFilter(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter>();
    return itemElement != null;
  }
  
  private static void SetDropZoneFilter(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  private static Boolean? GetDropZoneCategories(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories>();
    return itemElement != null;
  }
  
  private static void SetDropZoneCategories(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  private static Boolean? GetDropZoneData(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData>();
    return itemElement != null;
  }
  
  private static void SetDropZoneData(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  private static Boolean? GetDropZoneSeries(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries>();
    return itemElement != null;
  }
  
  private static void SetDropZoneSeries(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  private static Boolean? GetDropZonesVisible(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible>();
    return itemElement != null;
  }
  
  private static void SetDropZonesVisible(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions openXmlElement, Boolean? value)
  {
    if (value == false)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible>();
      if (itemElement != null)
        itemElement.Remove();
    }
    if (value == true)
    {
      var itemElement = new DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible();
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Charts.PivotOptions? CreateModelElement(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Charts.PivotOptions();
      value.DropZoneFilter = GetDropZoneFilter(openXmlElement);
      value.DropZoneCategories = GetDropZoneCategories(openXmlElement);
      value.DropZoneData = GetDropZoneData(openXmlElement);
      value.DropZoneSeries = GetDropZoneSeries(openXmlElement);
      value.DropZonesVisible = GetDropZonesVisible(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Charts.PivotOptions? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetDropZoneFilter(openXmlElement, value?.DropZoneFilter);
      SetDropZoneCategories(openXmlElement, value?.DropZoneCategories);
      SetDropZoneData(openXmlElement, value?.DropZoneData);
      SetDropZoneSeries(openXmlElement, value?.DropZoneSeries);
      SetDropZonesVisible(openXmlElement, value?.DropZonesVisible);
      return openXmlElement;
    }
    return default;
  }
}
