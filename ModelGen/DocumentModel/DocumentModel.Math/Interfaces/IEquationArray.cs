namespace DocumentModel.Math;

/// <summary>
/// Equation-Array Function.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Math.IEquationArrayProperties))]
[ChildElementInfo(typeof(DocumentModel.Math.IBase))]
public interface IEquationArray // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Equation Array Properties.
  /// </summary>
  public IEquationArrayProperties? EquationArrayProperties { get ; set; }
  
}
