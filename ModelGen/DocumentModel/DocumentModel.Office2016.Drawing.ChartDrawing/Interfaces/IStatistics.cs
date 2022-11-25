namespace DocumentModel.Office2016.Drawing.ChartDrawing;

/// <summary>
/// Defines the Statistics Class.
/// </summary>
public interface IStatistics // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// quartileMethod, this property is only available in Office 2016 and later.
  /// </summary>
  public DocumentModel.Office2016.Drawing.ChartDrawing.QuartileMethod? QuartileMethod { get ; set; }
  
}
