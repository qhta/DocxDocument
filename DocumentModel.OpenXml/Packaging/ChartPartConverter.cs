using DocumentModel.Drawings.Charts;
using DocumentModel.OpenXml.Drawings.Charts;
using DocumentModel.Packaging;
using ChartPart = DocumentFormat.OpenXml.Packaging.ChartPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the ChartPart
/// </summary>
public static class ChartPartConverter
{
  /// <summary>
  ///   Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public static Collection<ChartColorStylePart>? GetChartColorStyleParts(ChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ChartColorStylePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartColorStylePart>())
      {
        var newItem = ChartColorStylePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static ChartSpace? GetChartSpace(ChartPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Drawing.Charts.ChartSpace rootElement)
      return ChartSpaceConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetChartSpace(ChartPart? openXmlElement, ChartSpace? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = ChartSpaceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Charts.ChartSpace>(value);
        if (rootElement != null)
          openXmlElement.ChartSpace = rootElement;
      }
  }

  /// <summary>
  ///   Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public static Collection<ChartStylePart>? GetChartStyleParts(ChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ChartStylePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartStylePart>())
      {
        var newItem = ChartStylePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static String? GetContentType(ChartPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ImageParts of the ChartPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(ChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new Collection<ImagePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
      {
        var newItem = ImagePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }

  public static String? GetRelationshipType(ChartPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.ChartPart? CreateModelElement(ChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ChartPart();
      value.ChartColorStyleParts = GetChartColorStyleParts(openXmlElement);
      value.ChartSpace = GetChartSpace(openXmlElement);
      value.ChartStyleParts = GetChartStyleParts(openXmlElement);
      value.ContentType = GetContentType(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ChartPart? value)
    where OpenXmlElementType : ChartPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetChartColorStyleParts(openXmlElement, value?.ChartColorStyleParts);
      SetChartSpace(openXmlElement, value?.ChartSpace);
      //SetChartStyleParts(openXmlElement, value?.ChartStyleParts);
      //SetContentType(openXmlElement, value?.ContentType);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}