namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a default line that is used within a document.
/// </summary>
public partial class LineDefault
{
  public ShapeProperties? ShapeProperties { get; set; }
  
  public BodyProperties? BodyProperties { get; set; }
  
  public ListStyle? ListStyle { get; set; }
  
  public ShapeStyle? ShapeStyle { get; set; }
  
  public ExtensionList? ExtensionList { get; set; }
  
}
