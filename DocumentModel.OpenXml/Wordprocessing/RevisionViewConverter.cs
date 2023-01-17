namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Visibility of Annotation Types.
/// </summary>
public static class RevisionViewConverter
{
  /// <summary>
  /// Display Visual Indicator Of Markup Area
  /// </summary>
  private static Boolean? GetMarkup(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement)
  {
    return openXmlElement?.Markup?.Value;
  }
  
  private static void SetMarkup(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Markup = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Markup = null;
  }
  
  /// <summary>
  /// Display Comments
  /// </summary>
  private static Boolean? GetComments(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement)
  {
    return openXmlElement?.Comments?.Value;
  }
  
  private static void SetComments(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Comments = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Comments = null;
  }
  
  /// <summary>
  /// Display Content Revisions
  /// </summary>
  private static Boolean? GetDisplayRevision(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement)
  {
    return openXmlElement?.DisplayRevision?.Value;
  }
  
  private static void SetDisplayRevision(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.DisplayRevision = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.DisplayRevision = null;
  }
  
  /// <summary>
  /// Display Formatting Revisions
  /// </summary>
  private static Boolean? GetFormatting(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement)
  {
    return openXmlElement?.Formatting?.Value;
  }
  
  private static void SetFormatting(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.Formatting = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.Formatting = null;
  }
  
  /// <summary>
  /// Display Ink Annotations
  /// </summary>
  private static Boolean? GetInkAnnotations(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement)
  {
    return openXmlElement?.InkAnnotations?.Value;
  }
  
  private static void SetInkAnnotations(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement, Boolean? value)
  {
    if (value != null)
      openXmlElement.InkAnnotations = new OnOffValue { Value = (Boolean)value };
    else
      openXmlElement.InkAnnotations = null;
  }
  
  public static DocumentModel.Wordprocessing.RevisionView? CreateModelElement(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.RevisionView();
      value.Markup = GetMarkup(openXmlElement);
      value.Comments = GetComments(openXmlElement);
      value.DisplayRevision = GetDisplayRevision(openXmlElement);
      value.Formatting = GetFormatting(openXmlElement);
      value.InkAnnotations = GetInkAnnotations(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.RevisionView? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Wordprocessing.RevisionView, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetMarkup(openXmlElement, value?.Markup);
      SetComments(openXmlElement, value?.Comments);
      SetDisplayRevision(openXmlElement, value?.DisplayRevision);
      SetFormatting(openXmlElement, value?.Formatting);
      SetInkAnnotations(openXmlElement, value?.InkAnnotations);
      return openXmlElement;
    }
    return default;
  }
}
