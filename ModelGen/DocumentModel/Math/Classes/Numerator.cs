namespace DocumentModel.Math;


/// <summary>
///   Numerator.
/// </summary>
public partial class Numerator
{
  public ArgumentProperties? ArgumentProperties { get; set; }
  
  public ControlProperties? ControlProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
