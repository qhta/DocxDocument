namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the OpenXmlValueColorEndPositionElement Class.
/// </summary>
public interface IOpenXmlValueColorEndPositionElement // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// ExtremeValueColorPosition.
  /// </summary>
  public System.Boolean? ExtremeValueColorPosition { get ; set; }
  
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public System.Double? NumberColorPosition { get ; set; }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public System.Double? PercentageColorPosition { get ; set; }
  
}
