using DocumentModel.Packaging;

namespace DocumentModel.OpenXml.Packaging;

/// <summary>
///   Called from constructors of derived parts to initialize the IFixedContentTypePart interface. All derived parts must
///   be parts that have fixed content type.
/// </summary>
public static class IFixedContentTypePartConverter
{
  public static IFixedContentTypePart? CreateModelElement(DocumentFormat.OpenXml.Packaging.IFixedContentTypePart? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new IFixedContentTypePart();
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(IFixedContentTypePart? value)
    where OpenXmlElementType : DocumentFormat.OpenXml.Packaging.IFixedContentTypePart, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      return openXmlElement;
    }
    return default;
  }
}