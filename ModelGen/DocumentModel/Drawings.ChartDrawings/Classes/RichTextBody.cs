namespace DocumentModel.Drawings.ChartDrawings;


/// <summary>
///   Defines the RichTextBody Class.
/// </summary>
public partial class RichTextBody
{
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get; set; }
  
  public DocumentModel.Drawings.ListStyle? ListStyle { get; set; }
  
  public DM.ElementCollection<Paragraph>? Items { get; set; }
  
}
