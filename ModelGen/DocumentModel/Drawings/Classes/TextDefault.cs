namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the default formatting which is applied to text in a document by default.  The default formatting can and should be applied to the shape when it is initially inserted into a document.
/// </summary>
public partial class TextDefault
{
  public ShapeProperties? ShapeProperties { get; set; }
  
  public BodyProperties? BodyProperties { get; set; }
  
  public ListStyle? ListStyle { get; set; }
  
  public ShapeStyle? ShapeStyle { get; set; }
  
  public ExtensionList? ExtensionList { get; set; }
  
}
