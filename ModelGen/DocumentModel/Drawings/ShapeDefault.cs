namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the formatting that is associated with the default shape.  The default formatting can be applied to a shape when it is initially inserted into a document.
/// </summary>
public partial class ShapeDefault
{
  public DMD.ShapeProperties? ShapeProperties { get; set; }
  
  public DMD.BodyProperties? BodyProperties { get; set; }
  
  public DMD.ListStyle? ListStyle { get; set; }
  
  public DMD.ShapeStyle? ShapeStyle { get; set; }
  
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
