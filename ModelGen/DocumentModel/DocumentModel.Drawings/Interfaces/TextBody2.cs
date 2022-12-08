namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextBody Class.
/// </summary>
public interface TextBody2
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
