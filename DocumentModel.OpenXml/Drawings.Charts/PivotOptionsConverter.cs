namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
/// Defines the PivotOptions Class.
/// </summary>
public static class PivotOptionsConverter
{
  /// <summary>
  /// DropZoneFilter.
  /// </summary>
  public static Boolean? GetDropZoneFilter(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneFilter>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDropZoneFilter(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// DropZoneCategories.
  /// </summary>
  public static Boolean? GetDropZoneCategories(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneCategories>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDropZoneCategories(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// DropZoneData.
  /// </summary>
  public static Boolean? GetDropZoneData(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneData>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDropZoneData(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// DropZoneSeries.
  /// </summary>
  public static Boolean? GetDropZoneSeries(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZoneSeries>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDropZoneSeries(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  }
  
  /// <summary>
  /// DropZonesVisible.
  /// </summary>
  public static Boolean? GetDropZonesVisible(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2010.Drawing.Charts.DropZonesVisible>();
      return itemElement != null;
    }
    return null;
  }
  
  public static void SetDropZonesVisible(DocumentFormat.OpenXml.Office2010.Drawing.Charts.PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
