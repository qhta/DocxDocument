namespace DocumentModel.Math;


/// <summary>
///   Base.
/// </summary>
public partial class Base
{
  public ArgumentProperties? ArgumentProperties { get; set; }
  
  public ControlProperties? ControlProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
