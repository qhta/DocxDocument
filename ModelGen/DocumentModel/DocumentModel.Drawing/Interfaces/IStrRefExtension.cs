namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
public interface IStrRefExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Drawing.IFullReference? FullReference { get ; set; }
  
  public DocumentModel.Drawing.ILevelReference? LevelReference { get ; set; }
  
  public DocumentModel.Drawing.IFormulaReference? FormulaReference { get ; set; }
  
}
