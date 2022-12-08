namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
public interface TextProperties2
{
  public BodyProperties? BodyProperties { get ; set; }
  
  public ListStyle? ListStyle { get ; set; }
  
  public Collection<Paragraph>? Paragraphs { get ; set; }
  
}
