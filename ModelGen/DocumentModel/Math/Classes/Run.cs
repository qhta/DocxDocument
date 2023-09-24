namespace DocumentModel.Math;


/// <summary>
///   Defines the Run Class.
/// </summary>
public partial class Run
{
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public RunProperties? MathRunProperties { get; set; }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  public RunProperties? RunProperties { get; set; }
  
  public ElementCollection<IModelElement>? Items { get; set; }
  
}
