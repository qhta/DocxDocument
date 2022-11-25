namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the ExternalData Class.
/// </summary>
public interface IExternalData // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// RelId of the relationship for the external data, this property is only available in Office 2016 and later.
  /// </summary>
  public System.String? Id { get ; set; }
  
  /// <summary>
  /// True if the external link should automatically update, this property is only available in Office 2016 and later.
  /// </summary>
  public System.Boolean? AutoUpdate { get ; set; }
  
}
