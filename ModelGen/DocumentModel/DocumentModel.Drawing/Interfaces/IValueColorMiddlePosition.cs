namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ValueColorMiddlePosition Class.
/// </summary>
public interface IValueColorMiddlePosition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public Double? NumberColorPosition { get ; set; }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public Double? PercentageColorPosition { get ; set; }
  
}
