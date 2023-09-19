namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the HyperlinkRuby Class.
/// </summary>
public partial class HyperlinkRuby
{
  
  /// <summary>
  ///   tgtFrame
  /// </summary>
  [SchemaAttr("w:tgtFrame")]
  public String? TargetFrame { get; set; }
  
  
  /// <summary>
  ///   tooltip
  /// </summary>
  [SchemaAttr("w:tooltip")]
  public String? Tooltip { get; set; }
  
  
  /// <summary>
  ///   docLocation
  /// </summary>
  [SchemaAttr("w:docLocation")]
  public String? DocLocation { get; set; }
  
  
  /// <summary>
  ///   history
  /// </summary>
  [SchemaAttr("w:history")]
  public Boolean? History { get; set; }
  
  
  /// <summary>
  ///   anchor
  /// </summary>
  [SchemaAttr("w:anchor")]
  public String? Anchor { get; set; }
  
  
  /// <summary>
  ///   id
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
