namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Wordprocessing.IPreviousParagraphMarkRunProperties))]
public class ParagraphMarkRunPropertiesChange: IParagraphMarkRunPropertiesChange
{
  /// <summary>
  /// author
  /// </summary>
  public string? Author
  {
    get;
    set;
  }
  
  /// <summary>
  /// date
  /// </summary>
  public DateTime? Date
  {
    get;
    set;
  }
  
  /// <summary>
  /// Annotation Identifier
  /// </summary>
  public string? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// Previous Run Properties for the Paragraph Mark.
  /// </summary>
  public IPreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties
  {
    get;
    set;
  }
  
}
