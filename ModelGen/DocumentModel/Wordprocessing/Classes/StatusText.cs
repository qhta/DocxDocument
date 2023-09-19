namespace DocumentModel.Wordprocessing;


/// <summary>
///   Associated Status Text.
/// </summary>
public partial class StatusText
{
  
  /// <summary>
  ///   Status Text Type
  /// </summary>
  [SchemaAttr("w:type")]
  public DocumentModel.Wordprocessing.InfoTextValues? Type { get; set; }
  
  
  /// <summary>
  ///   Status Text Value
  /// </summary>
  [SchemaAttr("w:val")]
  public String? Val { get; set; }
  
}
