namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
public interface ICatAxExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.INumberingFormat? NumberingFormat { get ; set; }
  
}
