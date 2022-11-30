namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
public interface IValAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.INumberingFormat? NumberingFormat { get ; set; }
  
}
