namespace DocumentModel.Math;


/// <summary>
///   Upper limit (n-ary).
/// </summary>
public partial class SuperArgument
{
  public DocumentModel.Math.ArgumentProperties? ArgumentProperties { get; set; }
  
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
