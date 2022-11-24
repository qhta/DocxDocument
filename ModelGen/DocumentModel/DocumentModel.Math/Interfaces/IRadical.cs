namespace DocumentModel.Math;

/// <summary>
/// Radical Function.
/// </summary>
public interface IRadical // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Radical Properties.
  /// </summary>
  public IRadicalProperties? RadicalProperties { get ; set; }
  
  /// <summary>
  /// Degree.
  /// </summary>
  public IDegree? Degree { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
}
