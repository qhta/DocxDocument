namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the ExtendedChartPart
/// </summary>
public static class ExtendedChartPartConverter
{
  /// <summary>
  /// Gets the ChartColorStyleParts of the ExtendedChartPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartColorStylePart>? GetChartColorStyleParts(DocumentFormat.OpenXml.Packaging.ExtendedChartPart? openXmlElement)
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
  public static DocumentModel.Drawings.ChartDrawings.ChartSpace? GetChartSpace(DocumentFormat.OpenXml.Packaging.ExtendedChartPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetChartSpace(DocumentFormat.OpenXml.Packaging.ExtendedChartPart? openXmlElement, DocumentModel.Drawings.ChartDrawings.ChartSpace? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  /// <summary>
  /// Gets the ChartStyleParts of the ExtendedChartPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ChartStylePart>? GetChartStyleParts(DocumentFormat.OpenXml.Packaging.ExtendedChartPart? openXmlElement)
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
  
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.ExtendedChartPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets the ImageParts of the ExtendedChartPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.ExtendedChartPart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.ExtendedChartPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.ExtendedChartPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.ExtendedChartPart? openXmlElement)
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
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.ExtendedChartPart, new()
  {
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
