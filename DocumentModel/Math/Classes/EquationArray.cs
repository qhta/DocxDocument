namespace DocumentModel.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
public partial class EquationArray
{
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  public DocumentModel.Math.EquationArrayProperties? EquationArrayProperties { get; set; }
  
  public Collection<DocumentModel.Math.Base>? Bases { get; set; }
  
}
