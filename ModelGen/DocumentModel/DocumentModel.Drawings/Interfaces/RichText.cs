namespace DocumentModel.Drawings;

/// <summary>
/// Rich Text.
/// </summary>
public interface RichText
{
  public BodyProperties? BodyProperties { get ; set; }
  
  public ListStyle? ListStyle { get ; set; }
  
}
