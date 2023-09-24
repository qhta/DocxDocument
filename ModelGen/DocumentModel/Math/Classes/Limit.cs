namespace DocumentModel.Math;


/// <summary>
///   Limit (Lower).
/// </summary>
public partial class Limit
{
  public ArgumentProperties? ArgumentProperties { get; set; }
  
  public ControlProperties? ControlProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
