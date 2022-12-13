namespace DocumentModel.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
public interface EquationArray
{
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  public DocumentModel.Math.EquationArrayProperties? EquationArrayProperties { get ; set; }
  
  public DocumentModel.Math.Base? Base { get ; set; }
  
}
