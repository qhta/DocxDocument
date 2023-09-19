namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the primary name for the current style in the document. This name can be used in an application's user interface as desired. The actual primary name for this style is stored in its val attribute.
/// </summary>
public partial class DocPartName
{
  
  /// <summary>
  ///   Name Value
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
  
  /// <summary>
  ///   Built-In Entry
  /// </summary>
  [SchemaAttr("w:decorated")]
  public Boolean? Decorated { get; set; }
  
}
