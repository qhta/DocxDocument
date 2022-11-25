namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Plot data and formatting.
/// </summary>
public interface IPlotArea // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Layout.
  /// </summary>
  public DocumentModel.Drawing.Charts.ILayout? Layout { get ; set; }
  
}
