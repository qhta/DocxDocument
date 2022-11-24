namespace DocumentModel.Math;

/// <summary>
/// Defines the Run Class.
/// </summary>
public interface IRun // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Run Properties.
  /// </summary>
  public IRunProperties? MathRunProperties { get ; set; }
  
  /// <summary>
  /// Run Properties.
  /// </summary>
  public IRunProperties? RunProperties { get ; set; }
  
}
