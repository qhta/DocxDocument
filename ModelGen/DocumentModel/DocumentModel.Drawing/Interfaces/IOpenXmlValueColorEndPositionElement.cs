namespace DocumentModel.Drawing;

/// <summary>
/// Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public interface IOpenXmlValueColorEndPositionElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ExtremeValueColorPosition.
  /// </summary>
  public Boolean? ExtremeValueColorPosition { get ; set; }
  
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public Double? NumberColorPosition { get ; set; }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public Double? PercentageColorPosition { get ; set; }
  
}
