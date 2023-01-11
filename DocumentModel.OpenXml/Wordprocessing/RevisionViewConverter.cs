namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Visibility of Annotation Types.
/// </summary>
public static class RevisionViewConverter
{
  /// <summary>
  /// Display Visual Indicator Of Markup Area
  /// </summary>
  public static Boolean? GetMarkup(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement)
  {
    return openXmlElement?.Markup?.Value;
  }
  
  public static void SetMarkup(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Markup = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Markup = null;
  }
  
  /// <summary>
  /// Display Comments
  /// </summary>
  public static Boolean? GetComments(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement)
  {
    return openXmlElement?.Comments?.Value;
  }
  
  public static void SetComments(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Comments = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Comments = null;
  }
  
  /// <summary>
  /// Display Content Revisions
  /// </summary>
  public static Boolean? GetDisplayRevision(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement)
  {
    return openXmlElement?.DisplayRevision?.Value;
  }
  
  public static void SetDisplayRevision(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.DisplayRevision = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.DisplayRevision = null;
  }
  
  /// <summary>
  /// Display Formatting Revisions
  /// </summary>
  public static Boolean? GetFormatting(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement)
  {
    return openXmlElement?.Formatting?.Value;
  }
  
  public static void SetFormatting(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
      if (value != null)
        openXmlElement.Formatting = new OnOffValue { Value = (Boolean)value };
      else
        openXmlElement.Formatting = null;
  }
  
  /// <summary>
  /// Display Ink Annotations
  /// </summary>
  public static Boolean? GetInkAnnotations(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement)
  {
    return openXmlElement?.InkAnnotations?.Value;
  }
  
  public static void SetInkAnnotations(DocumentFormat.OpenXml.Wordprocessing.RevisionView? openXmlElement, Boolean? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
