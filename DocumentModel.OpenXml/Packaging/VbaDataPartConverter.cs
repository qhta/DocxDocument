using DocumentFormat.OpenXml.Packaging;
using DocumentModel.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Defines the VbaDataPart
/// </summary>
public static class VbaDataPartConverter
{
  public static String? GetContentType(VbaDataPart? openXmlElement)
  {
    return openXmlElement?.ContentType;
  }

  public static String? GetRelationshipType(VbaDataPart? openXmlElement)
  {
    return openXmlElement?.RelationshipType;
  }

  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public static VbaSuppData? GetVbaSuppData(VbaDataPart? openXmlElement)
  {
    if (openXmlElement?.RootElement is DocumentFormat.OpenXml.Office.Word.VbaSuppData rootElement)
      return VbaSuppDataConverter.CreateModelElement(rootElement);
    return null;
  }

  public static void SetVbaSuppData(VbaDataPart? openXmlElement, VbaSuppData? value)
  {
    if (openXmlElement != null)
      if (value != null)
      {
        var rootElement = VbaSuppDataConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Office.Word.VbaSuppData>(value);
        if (rootElement != null)
          openXmlElement.VbaSuppData = rootElement;
      }
  }

  public static DocumentModel.Packaging.VbaDataPart? CreateModelElement(VbaDataPart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Packaging.VbaDataPart();
      value.ContentType = GetContentType(openXmlElement);
      value.RelationshipType = GetRelationshipType(openXmlElement);
      value.VbaSuppData = GetVbaSuppData(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Packaging.VbaDataPart? value)
    where OpenXmlElementType : VbaDataPart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      //SetContentType(openXmlElement, value?.ContentType);
      //SetRelationshipType(openXmlElement, value?.RelationshipType);
      SetVbaSuppData(openXmlElement, value?.VbaSuppData);
      return openXmlElement;
    }
    return default;
  }
}