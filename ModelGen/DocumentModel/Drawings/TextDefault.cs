namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the default formatting which is applied to text in a document by default.  The default formatting can and should be applied to the shape when it is initially inserted into a document.
/// </summary>
public partial class TextDefault
{
  public DMD.ShapeProperties? ShapeProperties { get; set; }
  
  public DMD.BodyProperties? BodyProperties { get; set; }
  
  public DMD.ListStyle? ListStyle { get; set; }
  
  public DMD.ShapeStyle? ShapeStyle { get; set; }
  
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
