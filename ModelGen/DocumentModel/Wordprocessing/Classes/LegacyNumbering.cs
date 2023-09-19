namespace DocumentModel.Wordprocessing;


/// <summary>
///   Legacy Numbering Level Properties.
/// </summary>
public partial class LegacyNumbering
{
  
  /// <summary>
  ///   Use Legacy Numbering Properties
  /// </summary>
  [SchemaAttr("w:legacy")]
  public Boolean? Legacy { get; set; }
  
  
  /// <summary>
  ///   Legacy Spacing
  /// </summary>
  [SchemaAttr("w:legacySpace")]
  public String? LegacySpace { get; set; }
  
  
  /// <summary>
  ///   Legacy Indent
  /// </summary>
  [SchemaAttr("w:legacyIndent")]
  public String? LegacyIndent { get; set; }
  
}
