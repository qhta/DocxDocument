namespace DocumentModel.Math;

/// <summary>
/// Border-Box Function.
/// </summary>
public interface IBorderBox // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Border Box Properties.
  /// </summary>
  public IBorderBoxProperties? BorderBoxProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
}
