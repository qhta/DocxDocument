namespace DocumentModel.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public interface IBorderBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public DocumentModel.Math.IBorderBoxProperties? BorderBoxProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Base { get ; set; }
  
}
