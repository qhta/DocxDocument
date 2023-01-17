namespace DocumentModel.OpenXml.Packaging;

/// <summary>
/// Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public static class RibbonAndBackstageCustomizationsPartConverter
{
  private static String? GetContentType(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart openXmlElement)
  {
    return openXmlElement?.ContentType;
  }
  
  /// <summary>
  /// Gets or sets the root element of this part.
  /// </summary>
  private static DocumentModel.CustomUI? GetCustomUI(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI rootElement)
      return DocumentModel.OpenXml.CustomUIConverter.CreateModelElement(rootElement);
    return null;
  }
  
  private static void SetCustomUI(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart openXmlElement, DocumentModel.CustomUI? value)
  {
    if (value != null)
    {
       var rootElement = DocumentModel.OpenXml.CustomUIConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI>(value);
       if (rootElement != null)
         openXmlElement.CustomUI = rootElement;
    }
  }
  
  /// <summary>
  /// Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
  /// </summary>
  private static System.Collections.ObjectModel.Collection<DocumentModel.Packaging.ImagePart> GetImageParts(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart openXmlElement)
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
  
  private static String? GetRelationshipType(DocumentFormat.OpenXml.Packaging.RibbonAndBackstageCustomizationsPart openXmlElement)
  {
    return openXmlElement?.RelationshipType;
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
      //SetContentType(openXmlElement, value?.ContentType);
      SetCustomUI(openXmlElement, value?.CustomUI);
      //SetImageParts(openXmlElement, value?.ImageParts);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      return openXmlElement;
    }
    return default;
  }
}
