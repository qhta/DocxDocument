using DocumentFormat.OpenXml.Packaging;
using ImagePart = DocumentModel.Packaging.ImagePart;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the RibbonAndBackstageCustomizationsPart
/// </summary>
public static class RibbonAndBackstageCustomizationsPartConverter
{
  public static String? GetContentType(RibbonAndBackstageCustomizationsPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static CustomUI? GetCustomUI(RibbonAndBackstageCustomizationsPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI rootElement)
      return CustomUIConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetCustomUI(RibbonAndBackstageCustomizationsPart? openXmlElement, CustomUI? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = CustomUIConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office2010.CustomUI.CustomUI>(value);
        if (rootElement != null)
          openXmlElement.CustomUI = rootElement;
      }
  }

  /// <summary>
  ///   Gets the ImageParts of the RibbonAndBackstageCustomizationsPart
  /// </summary>
  public static Collection<ImagePart>? GetImageParts(RibbonAndBackstageCustomizationsPart? openXmlElement)
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

  public static String? GetRelationshipType(RibbonAndBackstageCustomizationsPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  public static DocumentModel.Packaging.RibbonAndBackstageCustomizationsPart? CreateModelElement(RibbonAndBackstageCustomizationsPart? openXmlElement)
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
    where OpenXmlElementType : RibbonAndBackstageCustomizationsPart, new()
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