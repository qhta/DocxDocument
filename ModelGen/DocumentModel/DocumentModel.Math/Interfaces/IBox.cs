namespace DocumentModel.Math;

/// <summary>
/// Box Function.
/// </summary>
public interface IBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Box Properties.
  /// </summary>
  public IBoxProperties? BoxProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
}
