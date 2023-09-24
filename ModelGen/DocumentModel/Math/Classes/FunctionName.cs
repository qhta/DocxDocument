namespace DocumentModel.Math;


/// <summary>
///   Function Name.
/// </summary>
public partial class FunctionName
{
  public ArgumentProperties? ArgumentProperties { get; set; }
  
  public ControlProperties? ControlProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
