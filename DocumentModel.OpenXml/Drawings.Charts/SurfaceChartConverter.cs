using DocumentFormat.OpenXml.Drawing.Charts;
using BandFormats = DocumentModel.Drawings.Charts.BandFormats;
using SurfaceChartExtensionList = DocumentModel.Drawings.Charts.SurfaceChartExtensionList;
using SurfaceChartSeries = DocumentModel.Drawings.Charts.SurfaceChartSeries;

namespace DocumentModel.OpenXml.Drawings.Charts;

/// <summary>
///   Surface Charts.
/// </summary>
public static class SurfaceChartConverter
{
  /// <summary>
  ///   Wireframe.
  /// </summary>
  public static Boolean? GetWireframe(SurfaceChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<Wireframe>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetWireframe(SurfaceChart? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<Wireframe>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new Wireframe();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<SurfaceChartSeries>? GetSurfaceChartSerieses(SurfaceChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<SurfaceChartSeries>();
      foreach (var item in openXmlElement.Elements<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>())
      {
        var newItem = SurfaceChartSeriesConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetSurfaceChartSerieses(SurfaceChart? openXmlElement, Collection<SurfaceChartSeries>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = SurfaceChartSeriesConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartSeries>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static BandFormats? GetBandFormats(SurfaceChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BandFormats>();
    if (itemElement != null)
      return BandFormatsConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetBandFormats(SurfaceChart? openXmlElement, BandFormats? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.BandFormats>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BandFormatsConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.BandFormats>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static Collection<UInt32>? GetAxisIds(SurfaceChart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<UInt32>();
      foreach (var item in openXmlElement.Elements<AxisId>())
      {
        var newItem = UInt32ValueConverter.GetValue(item);
        if (newItem != null)
          collection.Add((UInt32)newItem);
      }
      return collection;
    }
    return null;
  }

  public static void SetAxisIds(SurfaceChart? openXmlElement, Collection<UInt32>? value)
  {
    if (openXmlElement != null)
    {
      openXmlElement.RemoveAllChildren<AxisId>();
      if (value != null)
        foreach (var item in value)
        {
          var newItem = UInt32ValueConverter.CreateOpenXmlElement<AxisId>(item);
          if (newItem != null)
            openXmlElement.AddChild(newItem);
        }
    }
  }

  public static SurfaceChartExtensionList? GetSurfaceChartExtensionList(SurfaceChart? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList>();
    if (itemElement != null)
      return SurfaceChartExtensionListConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetSurfaceChartExtensionList(SurfaceChart? openXmlElement, SurfaceChartExtensionList? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SurfaceChartExtensionListConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.SurfaceChartExtensionList>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Charts.SurfaceChart? CreateModelElement(SurfaceChart? openXmlElement)
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
    where OpenXmlElementType : SurfaceChart, new()
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