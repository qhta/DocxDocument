namespace DocumentModel.Math;

/// <summary>
/// Group-Character Function.
/// </summary>
public interface IGroupChar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Group-Character Properties.
  /// </summary>
  public IGroupCharProperties? GroupCharProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
}
