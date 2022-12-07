namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ParagraphPropertiesChange Class.
/// </summary>
public interface ParagraphPropertiesChange
{
  /// <summary>
  /// Previous Paragraph Properties.
  /// </summary>
  public ParagraphPropertiesExtended? ParagraphPropertiesExtended { get ; set; }
  
}
