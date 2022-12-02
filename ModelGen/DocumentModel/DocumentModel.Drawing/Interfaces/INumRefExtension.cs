namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumRefExtension Class.
/// </summary>
public interface INumRefExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFullReference? FullReference { get ; set; }
  
  public DocumentModel.Drawing.ILevelReference? LevelReference { get ; set; }
  
  public DocumentModel.Drawing.IFormulaReference? FormulaReference { get ; set; }
  
}
