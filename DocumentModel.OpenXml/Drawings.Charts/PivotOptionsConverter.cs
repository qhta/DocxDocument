using DocumentFormat.OpenXml.Office2010.Drawing.Charts;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Defines the PivotOptions Class.
/// </summary>
public static class PivotOptionsConverter
{
  /// <summary>
  ///   DropZoneFilter.
  /// </summary>
  public static Boolean? GetDropZoneFilter(PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DropZoneFilter>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDropZoneFilter(PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DropZoneFilter>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DropZoneFilter();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DropZoneCategories.
  /// </summary>
  public static Boolean? GetDropZoneCategories(PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DropZoneCategories>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDropZoneCategories(PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DropZoneCategories>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DropZoneCategories();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DropZoneData.
  /// </summary>
  public static Boolean? GetDropZoneData(PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DropZoneData>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDropZoneData(PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DropZoneData>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DropZoneData();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DropZoneSeries.
  /// </summary>
  public static Boolean? GetDropZoneSeries(PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DropZoneSeries>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDropZoneSeries(PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DropZoneSeries>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DropZoneSeries();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DropZonesVisible.
  /// </summary>
  public static Boolean? GetDropZonesVisible(PivotOptions? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DropZonesVisible>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDropZonesVisible(PivotOptions? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DropZonesVisible>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DropZonesVisible();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.PivotOptions? CreateModelElement(PivotOptions? openXmlElement)
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
    where OpenXmlElementType : PivotOptions, new()
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