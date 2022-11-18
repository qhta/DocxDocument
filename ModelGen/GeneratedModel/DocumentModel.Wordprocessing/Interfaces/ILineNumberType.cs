namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineNumberType Class.
/// </summary>
public interface ILineNumberType // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Line Number Increments to Display
  /// </summary>
  public short? CountBy { get ; set; }
  
  /// <summary>
  /// Line Numbering Starting Value
  /// </summary>
  public short? Start { get ; set; }
  
  /// <summary>
  /// Distance Between Text and Line Numbering
  /// </summary>
  public string? Distance { get ; set; }
  
  /// <summary>
  /// Line Numbering Restart Setting
  /// </summary>
  public LineNumberRestart? Restart { get ; set; }
  
}
