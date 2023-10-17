namespace DocumentModel.Math;


/// <summary>
///   Lower limit (n-ary) .
/// </summary>
public partial class SubArgument
{
  public DocumentModel.Math.ArgumentProperties? ArgumentProperties { get; set; }
  
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
