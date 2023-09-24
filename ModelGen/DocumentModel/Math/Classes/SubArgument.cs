namespace DocumentModel.Math;


/// <summary>
///   Lower limit (n-ary) .
/// </summary>
public partial class SubArgument
{
  public ArgumentProperties? ArgumentProperties { get; set; }
  
  public ControlProperties? ControlProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
