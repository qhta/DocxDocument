namespace DocumentModel.Math;


/// <summary>
///   Base.
/// </summary>
public partial class Base
{
  public DocumentModel.Math.ArgumentProperties? ArgumentProperties { get; set; }
  
  public DocumentModel.Math.ControlProperties? ControlProperties { get; set; }
  
  public DM.ElementCollection<IModelElement>? Items { get; set; }
  
}
