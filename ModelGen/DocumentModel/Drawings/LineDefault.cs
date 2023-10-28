namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a default line that is used within a document.
/// </summary>
public partial class LineDefault
{
  public DMD.ShapeProperties? ShapeProperties { get; set; }
  
  public DMD.BodyProperties? BodyProperties { get; set; }
  
  public DMD.ListStyle? ListStyle { get; set; }
  
  public DMD.ShapeStyle? ShapeStyle { get; set; }
  
  public DMD.ExtensionList? ExtensionList { get; set; }
  
}
