namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ChartPart
/// </summary>
public static class ChartPartConverter
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ChartPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartColorStylePart>? GetChartColorStyleParts(DocumentFormat.OpenXml.Packaging.ChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartColorStylePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartColorStylePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.ChartColorStylePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.Drawings.Charts.ChartSpace? GetChartSpace(DocumentFormat.OpenXml.Packaging.ChartPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetChartSpace(DocumentFormat.OpenXml.Packaging.ChartPart? openXmlElement, DocumentModel.Drawings.Charts.ChartSpace? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ChartPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartStylePart>? GetChartStyleParts(DocumentFormat.OpenXml.Packaging.ChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartStylePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ChartStylePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.ChartStylePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.ChartPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets the ImageParts of the ChartPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.ChartPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var collection = new System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>();
      foreach (var item in openXmlElement.GetPartsOfType<DocumentFormat.OpenXml.Packaging.ImagePart>())
      {
        var newItem = DocumentModel.OpenXml.Packaging.ImagePartConverter.CreateModelElement(item);
        if (newItem != null)
          collection.Add(newItem);
      }
      return collection;
    }
    return null;
  }
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ChartPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }
  
  public static DocumentModel.Packaging.ChartPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ChartPart? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ChartPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetChartSpace(openXmlElement, value?.ChartSpace);
      return openXmlElement;
    }
    return default;
  }
}
