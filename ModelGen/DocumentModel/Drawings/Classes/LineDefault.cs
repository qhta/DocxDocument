namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a default line that is used within a document.
/// </summary>
public partial class LineDefault
{
  public DocumentModel.Drawings.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get; set; }
  
  public DocumentModel.Drawings.ListStyle? ListStyle { get; set; }
  
  public DocumentModel.Drawings.ShapeStyle? ShapeStyle { get; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
