namespace DocumentModel.Drawings;

/// <summary>
/// Defines the StrRefExtension Class.
/// </summary>
public interface StrRefExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public FullReference? FullReference { get ; set; }
  
  public LevelReference? LevelReference { get ; set; }
  
  public FormulaReference? FormulaReference { get ; set; }
  
}
