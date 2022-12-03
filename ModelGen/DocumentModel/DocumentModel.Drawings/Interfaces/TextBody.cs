namespace DocumentModel.Drawings;

/// <summary>
/// Shape Text Body.
/// </summary>
public interface TextBody // : DocumentModel.BaseTypes.ModelElement
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
