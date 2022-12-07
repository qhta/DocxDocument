namespace DocumentModel.Wordprocessing;

/// <summary>
/// Default Paragraph Properties.
/// </summary>
public class ParagraphPropertiesDefaultImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.ParagraphPropertiesDefault>, ParagraphPropertiesDefault
{
  /// <summary>
  /// Paragraph Properties.
  /// </summary>
  public ParagraphPropertiesBaseStyle? ParagraphPropertiesBaseStyle
  {
    get;
    set;
  }
  
}
