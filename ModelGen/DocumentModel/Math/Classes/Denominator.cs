namespace DocumentModel.Math;


/// <summary>
///   Denominator.
/// </summary>
public partial class Denominator
{
  public ArgumentProperties? ArgumentProperties { get; set; }
  
  public ControlProperties? ControlProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
