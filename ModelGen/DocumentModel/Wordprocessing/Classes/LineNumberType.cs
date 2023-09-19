namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LineNumberType Class.
/// </summary>
public partial class LineNumberType
{
  
  /// <summary>
  ///   Line Number Increments to Display
  /// </summary>
  [SchemaAttr("w:countBy")]
  public Int16? CountBy { get; set; }
  
  
  /// <summary>
  ///   Line Numbering Starting Value
  /// </summary>
  [SchemaAttr("w:start")]
  public Int16? Start { get; set; }
  
  
  /// <summary>
  ///   Distance Between Text and Line Numbering
  /// </summary>
  [SchemaAttr("w:distance")]
  public String? Distance { get; set; }
  
  
  /// <summary>
  ///   Line Numbering Restart Setting
  /// </summary>
  [SchemaAttr("w:restart")]
  public DocumentModel.Wordprocessing.LineNumberRestartValues? Restart { get; set; }
  
}
