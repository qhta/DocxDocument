namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CheckBoxSymbolType Class.
/// </summary>
public partial class CheckBoxSymbolType
{
  
  /// <summary>
  ///   font, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:font")]
  public String? Font { get; set; }
  
  
  /// <summary>
  ///   val, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("w14:val")]
  public DocumentModel.HexBinaryValue? Val { get; set; }
  
}
