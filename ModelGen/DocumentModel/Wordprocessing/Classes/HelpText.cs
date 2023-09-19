namespace DocumentModel.Wordprocessing;


/// <summary>
///   Associated Help Text.
/// </summary>
public partial class HelpText
{
  
  /// <summary>
  ///   Help Text Type
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.InfoTextValues? Type { get; set; }
  
  
  /// <summary>
  ///   Help Text Value
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
}
