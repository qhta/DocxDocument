namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableWidthDxaNilType Class.
/// </summary>
public partial class TableWidthDxaNilType
{
  
  /// <summary>
  ///   w
  /// </summary>
  [SchemaAttr("w:w")]
  public Int16? Width { get; set; }
  
  
  /// <summary>
  ///   type
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.TableWidthValues? Type { get; set; }
  
}
