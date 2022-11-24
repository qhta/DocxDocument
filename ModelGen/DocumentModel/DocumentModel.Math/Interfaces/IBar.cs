namespace DocumentModel.Math;

/// <summary>
/// Bar.
/// </summary>
public interface IBar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Bar Properties.
  /// </summary>
  public IBarProperties? BarProperties { get ; set; }
  
  /// <summary>
  /// Base.
  /// </summary>
  public IBase? Base { get ; set; }
  
}
