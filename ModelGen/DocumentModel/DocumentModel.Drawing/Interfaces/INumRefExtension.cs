namespace DocumentModel.Drawing;

/// <summary>
/// Defines the NumRefExtension Class.
/// </summary>
public interface INumRefExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public IFullReference? FullReference { get ; set; }
  
  public ILevelReference? LevelReference { get ; set; }
  
  public IFormulaReference? FormulaReference { get ; set; }
  
}
