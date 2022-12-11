namespace DocumentModel.Wordprocessing;

/// <summary>
/// Visibility of Annotation Types.
/// </summary>
public class RevisionViewImpl: ModelElementImpl, RevisionView
{
  public DocumentFormat.OpenXml.Wordprocessing.RevisionView? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.RevisionView?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RevisionViewImpl(): base() {}
  
  public RevisionViewImpl(DocumentFormat.OpenXml.Wordprocessing.RevisionView openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Display Visual Indicator Of Markup Area
  /// </summary>
  public Boolean? Markup
  {
    get => (Boolean?)OpenXmlElement?.Markup?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Markup = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Display Comments
  /// </summary>
  public Boolean? Comments
  {
    get => (Boolean?)OpenXmlElement?.Comments?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Comments = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Display Content Revisions
  /// </summary>
  public Boolean? DisplayRevision
  {
    get => (Boolean?)OpenXmlElement?.DisplayRevision?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.DisplayRevision = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Display Formatting Revisions
  /// </summary>
  public Boolean? Formatting
  {
    get => (Boolean?)OpenXmlElement?.Formatting?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Formatting = (System.Boolean?)value;
    }
  }
  
  /// <summary>
  /// Display Ink Annotations
  /// </summary>
  public Boolean? InkAnnotations
  {
    get => (Boolean?)OpenXmlElement?.InkAnnotations?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.InkAnnotations = (System.Boolean?)value;
    }
  }
  
}
