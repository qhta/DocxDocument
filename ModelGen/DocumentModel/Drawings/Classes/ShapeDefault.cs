namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the formatting that is associated with the default shape.  The default formatting can be applied to a shape when it is initially inserted into a document.
/// </summary>
public partial class ShapeDefault
{
  public DocumentModel.Drawings.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get; set; }
  
  public DocumentModel.Drawings.ListStyle? ListStyle { get; set; }
  
  public DocumentModel.Drawings.ShapeStyle? ShapeStyle { get; set; }
  
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
