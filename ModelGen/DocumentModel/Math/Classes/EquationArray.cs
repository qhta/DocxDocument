namespace DocumentModel.Math;


/// <summary>
///   Equation-Array Function.
/// </summary>
public partial class EquationArray
{
  
  /// <summary>
  ///   Equation Array Properties.
  /// </summary>
  public EquationArrayProperties? EquationArrayProperties { get; set; }
  
  public ElementCollection<Base>? Items { get; set; }
  
}
