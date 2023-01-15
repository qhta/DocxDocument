using DocumentModel.Wordprocessing;
using DocDefaults = DocumentFormat.OpenXml.Wordprocessing.DocDefaults;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Document Default Paragraph and Run Properties.
/// </summary>
public static class DocDefaultsConverter
{
  /// <summary>
  ///   Default Run Properties.
  /// </summary>
  public static RunPropertiesDefault? GetRunPropertiesDefault(DocDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault>();
    if (itemElement != null)
      return RunPropertiesDefaultConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRunPropertiesDefault(DocDefaults? openXmlElement, RunPropertiesDefault? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RunPropertiesDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.RunPropertiesDefault>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   Default Paragraph Properties.
  /// </summary>
  public static ParagraphPropertiesDefault? GetParagraphPropertiesDefault(DocDefaults? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault>();
    if (itemElement != null)
      return ParagraphPropertiesDefaultConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetParagraphPropertiesDefault(DocDefaults? openXmlElement, ParagraphPropertiesDefault? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ParagraphPropertiesDefaultConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.DocDefaults? CreateModelElement(DocDefaults? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.DocDefaults();
      value.RunPropertiesDefault = GetRunPropertiesDefault(openXmlElement);
      value.ParagraphPropertiesDefault = GetParagraphPropertiesDefault(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.DocDefaults? value)
    where OpenXmlElementType : DocDefaults, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetRunPropertiesDefault(openXmlElement, value?.RunPropertiesDefault);
      SetParagraphPropertiesDefault(openXmlElement, value?.ParagraphPropertiesDefault);
      return openXmlElement;
    }
    return default;
  }
}