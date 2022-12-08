namespace DocumentModel.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
public interface EquationArray
{
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  public EquationArrayProperties? EquationArrayProperties { get ; set; }
  
  public Collection<Base>? Bases { get ; set; }
  
}
