namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Rich Text.
/// </summary>
public partial class RichText
{
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get; set; }
  
  public DocumentModel.Drawings.ListStyle? ListStyle { get; set; }
  
  public DM.ElementCollection<Paragraph>? Items { get; set; }
  
}
