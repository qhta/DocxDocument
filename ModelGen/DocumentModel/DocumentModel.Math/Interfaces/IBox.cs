namespace DocumentModel.Math;

/// <summary>
/// Box Function.
/// </summary>
public interface IBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Box Properties.
  /// </summary>
  public DocumentModel.Math.IBoxProperties? BoxProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IBase? Base { get ; set; }
  
}
