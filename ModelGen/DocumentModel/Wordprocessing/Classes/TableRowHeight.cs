namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the height of the current table row within the current table. This height shall be used to determine the resulting height of the table row, which can be absolute or relative (depending on its attribute values).
/// </summary>
public partial class TableRowHeight
{
  
  /// <summary>
  ///   Table Row Height
  /// </summary>
  [SchemaAttr("w:val")]
  public UInt32? Val { get; set; }
  
  
  /// <summary>
  ///   Table Row Height Type
  /// </summary>
  [SchemaAttr("w:hRule")]
  public DocumentModel.Wordprocessing.HeightRuleValues? HeightType { get; set; }
  
}
