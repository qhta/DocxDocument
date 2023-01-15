using DocumentModel.Drawings.ChartDrawings;
using DocumentModel.OpenXml.Drawings.ChartDrawings;
using DocumentModel.Packaging;
using ExtendedChartPart = DocumentFormat.OpenXml.Packaging.ExtendedChartPart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the ExtendedChartPart
/// </summary>
public static class ExtendedChartPartConverter
{
  /// <summary>
  ///   Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public static Collection<ChartColorStylePart>? GetChartColorStyleParts(ExtendedChartPart? openXmlElement)
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
  public static ChartSpace? GetChartSpace(ExtendedChartPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace rootElement)
      return ChartSpaceConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetChartSpace(ExtendedChartPart? openXmlElement, ChartSpace? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = ChartSpaceConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ChartSpace>(value);
        if (rootElement != null)
          openXmlElement.ChartSpace = rootElement;
      }
  }

  /// <summary>
  ///   Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  public static Collection<ChartStylePart>? GetChartStyleParts(ExtendedChartPart? openXmlElement)
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

  public static String? GetContentType(ExtendedChartPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(ExtendedChartPart? openXmlElement)
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

  public static String? GetRelationshipType(ExtendedChartPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.ExtendedChartPart? CreateModelElement(ExtendedChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.ExtendedChartPart();
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

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.ExtendedChartPart? value)
    where OpenXmlElementType : ExtendedChartPart, new()
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