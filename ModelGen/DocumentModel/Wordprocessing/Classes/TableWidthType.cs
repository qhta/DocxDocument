namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableWidthType Class.
/// </summary>
public partial class TableWidthType
{
  
  /// <summary>
  ///   Table Width Value
  /// </summary>
  [SchemaAttr("w:w")]
  public String? Width { get; set; }
  
  
  /// <summary>
  ///   Table Width Type
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.TableWidthUnitValues? Type { get; set; }
  
}
