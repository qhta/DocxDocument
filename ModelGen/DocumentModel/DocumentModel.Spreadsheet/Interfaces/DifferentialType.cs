namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the DifferentialType Class.
/// </summary>
public interface DifferentialType // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Font Properties.
  /// </summary>
  public Font? Font { get ; set; }
  
  /// <summary>
  /// Number Format.
  /// </summary>
  public NumberingFormat? NumberingFormat { get ; set; }
  
  /// <summary>
  /// Fill.
  /// </summary>
  public Fill? Fill { get ; set; }
  
  /// <summary>
  /// Alignment.
  /// </summary>
  public Alignment? Alignment { get ; set; }
  
  /// <summary>
  /// Border Properties.
  /// </summary>
  public Border? Border { get ; set; }
  
  /// <summary>
  /// Protection Properties.
  /// </summary>
  public Protection? Protection { get ; set; }
  
  /// <summary>
  /// Future Feature Data Storage Area.
  /// </summary>
  public ExtensionList? ExtensionList { get ; set; }
  
}
