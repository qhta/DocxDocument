namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public static class RibbonAndBackstageCustomizationsPartConverter
{
  public static String? GetContentType(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  public static DocumentModel.CustomUI? GetCustomUI(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertyGetter: 1");
  }
  
  public static void SetCustomUI(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart? openXmlElement, DocumentModel.CustomUI? value)
  {
    throw new NotImplementedException("Not implemented in GeneratePropertySetter: 1");
  }
  
  /// <summary>
  /// Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
  /// </summary>
  public static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart>? GetImageParts(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart? openXmlElement)
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
  
  public static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart? openXmlElement)
  {
    throw new NotImplementedException("Not implemented in GenerateStringPropertyGetCode: propertyType is System.String");
  }
  
  public static DocumentModel.Packaging.RibbonAndBackstageCustomizationsPart? CreateModelElement(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.RibbonAndBackstageCustomizationsPart();
      value.ContentType = GetContentType(openXmlElement);
      value.CustomUI = GetCustomUI(openXmlElement);
      value.ImageParts = GetImageParts(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.RibbonAndBackstageCustomizationsPart? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetCustomUI(openXmlElement, value?.CustomUI);
      return openXmlElement;
    }
    return default;
  }
}
