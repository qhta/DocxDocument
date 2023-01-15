using DocumentFormat.OpenXml.Office2013.Word;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the SdtRepeatedSection Class.
/// </summary>
public static class SdtRepeatedSectionConverter
{
  /// <summary>
  ///   SectionTitle.
  /// </summary>
  public static String? GetSectionTitle(SdtRepeatedSection? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<SectionTitle>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }

  public static void SetSectionTitle(SdtRepeatedSection? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<SectionTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new SectionTitle { Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  /// <summary>
  ///   DoNotAllowInsertDeleteSection.
  /// </summary>
  public static Boolean? GetDoNotAllowInsertDeleteSection(SdtRepeatedSection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DoNotAllowInsertDeleteSection>();
      return itemElement != null;
    }
    return null;
  }

  public static void SetDoNotAllowInsertDeleteSection(SdtRepeatedSection? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
    {
      if (value == false)
      {
        var itemElement = openXmlElement.GetFirstChild<DoNotAllowInsertDeleteSection>();
        if (itemElement != null)
          itemElement.Remove();
      }
      if (value == true)
      {
        var itemElement = new DoNotAllowInsertDeleteSection();
        openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Wordprocessing.SdtRepeatedSection? CreateModelElement(SdtRepeatedSection? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.SdtRepeatedSection();
      value.SectionTitle = GetSectionTitle(openXmlElement);
      value.DoNotAllowInsertDeleteSection = GetDoNotAllowInsertDeleteSection(openXmlElement);
      return value;
    }
    return null;
  }

  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.SdtRepeatedSection? value)
    where OpenXmlElementType : SdtRepeatedSection, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetSectionTitle(openXmlElement, value?.SectionTitle);
      SetDoNotAllowInsertDeleteSection(openXmlElement, value?.DoNotAllowInsertDeleteSection);
      return openXmlElement;
    }
    return default;
  }
}