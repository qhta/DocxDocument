namespace DocumentModel.Math;


/// <summary>
///   Limit (Lower).
/// </summary>
public partial class Limit
{
  public DocumentModel.Math.ArgumentProperties? ArgumentProperties { get; set; }
  
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
