namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineNumberType Class.
/// </summary>
public interface ILineNumberType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Line Number Increments to Display
  /// </summary>
  public System.Int16? CountBy { get ; set; }
  
  /// <summary>
  /// Line Numbering Starting Value
  /// </summary>
  public System.Int16? Start { get ; set; }
  
  /// <summary>
  /// Distance Between Text and Line Numbering
  /// </summary>
  public System.String? Distance { get ; set; }
  
  /// <summary>
  /// Line Numbering Restart Setting
  /// </summary>
  public DocumentModel.Wordprocessing.LineNumberRestartKind? Restart { get ; set; }
  
}
