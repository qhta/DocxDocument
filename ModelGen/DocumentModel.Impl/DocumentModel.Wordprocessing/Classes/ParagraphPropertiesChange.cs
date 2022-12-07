namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphPropertiesChange Class.
/// </summary>
public class ParagraphPropertiesChangeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesChange>, ParagraphPropertiesChange
{
  /// <summary>
  /// Previous Paragraph Properties.
  /// </summary>
  public ParagraphPropertiesExtended? ParagraphPropertiesExtended
  {
    get;
    set;
  }
  
}
