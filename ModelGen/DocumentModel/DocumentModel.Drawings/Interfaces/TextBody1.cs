namespace DocumentModel.Drawings;

/// <summary>
/// Text Body.
/// </summary>
public interface TextBody1
{
  /// <summary>
  /// Body Properties.
  /// </summary>
  public BodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// Text List Styles.
  /// </summary>
  public ListStyle? ListStyle { get ; set; }
  
  public Collection<Paragraph>? Paragraphs { get ; set; }
  
}
