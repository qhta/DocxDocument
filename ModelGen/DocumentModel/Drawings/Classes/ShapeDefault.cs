namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the formatting that is associated with the default shape.  The default formatting can be applied to a shape when it is initially inserted into a document.
/// </summary>
public partial class ShapeDefault
{
  public ShapeProperties? ShapeProperties { get; set; }
  
  public BodyProperties? BodyProperties { get; set; }
  
  public ListStyle? ListStyle { get; set; }
  
  public ShapeStyle? ShapeStyle { get; set; }
  
  public ExtensionList? ExtensionList { get; set; }
  
}
