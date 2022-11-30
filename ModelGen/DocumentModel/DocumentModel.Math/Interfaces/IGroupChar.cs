namespace DocumentModel.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public interface IGroupChar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  public DocumentModel.Math.IGroupCharProperties? GroupCharProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IBase? Base { get ; set; }
  
}
