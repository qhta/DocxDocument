namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumRefExtension Class.
/// </summary>
public interface NumRefExtension // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FullReference? FullReference { get ; set; }
  
  public LevelReference? LevelReference { get ; set; }
  
  public FormulaReference? FormulaReference { get ; set; }
  
}
