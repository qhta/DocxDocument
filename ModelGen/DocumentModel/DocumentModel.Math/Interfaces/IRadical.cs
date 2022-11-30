namespace DocumentModel.Math;

/// <summary>
/// Radical Function.
/// </summary>
public interface IRadical // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Radical Properties.
  /// </summary>
  public DocumentModel.Math.IRadicalProperties? RadicalProperties { get ; set; }
  
  /// <summary>
  /// Degree.
  /// </summary>
  public DocumentModel.Math.IDegree? Degree { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IBase? Base { get ; set; }
  
}
