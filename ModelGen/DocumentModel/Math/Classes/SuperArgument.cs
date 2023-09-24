namespace DocumentModel.Math;


/// <summary>
///   Upper limit (n-ary).
/// </summary>
public partial class SuperArgument
{
  public ArgumentProperties? ArgumentProperties { get; set; }
  
  public ControlProperties? ControlProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
