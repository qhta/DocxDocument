namespace DocumentModel.Math;

/// <summary>
/// Bar.
/// </summary>
public interface IBar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bar Properties.
  /// </summary>
  public DocumentModel.Math.IBarProperties? BarProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public DocumentModel.Math.IOfficeMathArgumentType? Base { get ; set; }
  
}
