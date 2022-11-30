namespace DocumentModel.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
public interface IEquationArray // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  public DocumentModel.Math.IEquationArrayProperties? EquationArrayProperties { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Math.IBase>? Bases { get ; set; }
  
}
