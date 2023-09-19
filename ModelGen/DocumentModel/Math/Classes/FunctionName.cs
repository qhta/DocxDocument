namespace DocumentModel.Math;


/// <summary>
///   Function Name.
/// </summary>
public partial class FunctionName
{
  public DocumentModel.Math.ArgumentProperties? ArgumentProperties { get; set; }
  
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
