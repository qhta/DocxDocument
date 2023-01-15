using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using DocPartTypes = DocumentFormat.OpenXml.Wordprocessing.DocPartTypes;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Entry Types.
/// </summary>
public static class DocPartTypesConverter
{
  /// <summary>
  ///   Entry Is Of All Types
  /// </summary>
  public static Boolean? GetAll(DocPartTypes? openXmlElement)
  {
    return openXmlElement?.All?.Value;
  }

  public static void SetAll(DocPartTypes? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.All = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.All = null;
  }

  public static DocPartKind? GetDocPartType(DocPartTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocPartType>();
      if (itemElement?.Val?.Value != null) return EnumValueConverter.GetValue<DocPartValues, DocPartKind>(itemElement.Val.Value);
    }
    return null;
  }

  public static void SetDocPartType(DocPartTypes? openXmlElement, DocPartKind? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocPartType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = EnumValueConverter.CreateOpenXmlElement<DocPartType, DocPartValues, DocPartKind>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.DocPartTypes? CreateModelElement(DocPartTypes? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocPartTypes();
      value.All = GetAll(openXmlElement);
      value.DocPartType = GetDocPartType(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocPartTypes? value)
    where OpenXmlElementType : DocPartTypes, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetAll(openXmlElement, value?.All);
      SetDocPartType(openXmlElement, value?.DocPartType);
      return openXmlElement;
    }
    return default;
  }
}