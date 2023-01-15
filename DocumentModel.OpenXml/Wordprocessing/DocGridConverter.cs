using DocumentFormat.OpenXml.Wordprocessing;
using DocumentModel.Wordprocessing;
using DocGrid = DocumentFormat.OpenXml.Wordprocessing.DocGrid;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the DocGrid Class.
/// </summary>
public static class DocGridConverter
{
  /// <summary>
  ///   Document Grid Type
  /// </summary>
  public static DocGridKind? GetType(DocGrid? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocGridValues, DocGridKind>(openXmlElement?.Type?.Value);
  }

  public static void SetType(DocGrid? openXmlElement, DocGridKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Type = EnumValueConverter.CreateEnumValue<DocGridValues, DocGridKind>(value);
  }

  /// <summary>
  ///   Document Grid Line Pitch
  /// </summary>
  public static Int32? GetLinePitch(DocGrid? openXmlElement)
  {
    return openXmlElement?.LinePitch?.Value;
  }

  public static void SetLinePitch(DocGrid? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.LinePitch = value;
  }

  /// <summary>
  ///   Document Grid Character Pitch
  /// </summary>
  public static Int32? GetCharacterSpace(DocGrid? openXmlElement)
  {
    return openXmlElement?.CharacterSpace?.Value;
  }

  public static void SetCharacterSpace(DocGrid? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.CharacterSpace = value;
  }

  public static DocumentModel.Wordprocessing.DocGrid? CreateModelElement(DocGrid? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocGrid();
      value.Type = GetType(openXmlElement);
      value.LinePitch = GetLinePitch(openXmlElement);
      value.CharacterSpace = GetCharacterSpace(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocGrid? value)
    where OpenXmlElementType : DocGrid, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetType(openXmlElement, value?.Type);
      SetLinePitch(openXmlElement, value?.LinePitch);
      SetCharacterSpace(openXmlElement, value?.CharacterSpace);
      return openXmlElement;
    }
    return default;
  }
}