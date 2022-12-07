namespace DocumentModel.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
public class EquationArrayImpl: ModelElement<DocumentFormat.OpenXml.Math.EquationArray>, EquationArray
{
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  public EquationArrayProperties? EquationArrayProperties
  {
    get;
    set;
  }
  
}
