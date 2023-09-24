namespace DocumentModel.Math;


/// <summary>
///   Degree.
/// </summary>
public partial class Degree
{
  public ArgumentProperties? ArgumentProperties { get; set; }
  
  public ControlProperties? ControlProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
