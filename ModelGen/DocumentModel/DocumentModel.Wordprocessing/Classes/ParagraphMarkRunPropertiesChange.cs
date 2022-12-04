namespace DocumentModel.Wordprocessing;

/// <summary>
/// Revision Information for Run Properties on the Paragraph Mark.
/// </summary>
public class ParagraphMarkRunPropertiesChange
{
  /// <summary>
  /// Previous Run Properties for the Paragraph Mark.
  /// </summary>
  public PreviousParagraphMarkRunProperties? PreviousParagraphMarkRunProperties
  {
    get;
    set;
  }
  
}
