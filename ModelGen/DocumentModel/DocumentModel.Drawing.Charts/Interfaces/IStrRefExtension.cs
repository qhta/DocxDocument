namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
public interface IStrRefExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFullReference? FullReference { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.ILevelReference? LevelReference { get ; set; }
  
  public DocumentModel.Office2013.Drawing.Chart.IFormulaReference? FormulaReference { get ; set; }
  
}
