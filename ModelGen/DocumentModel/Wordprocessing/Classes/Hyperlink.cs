namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Hyperlink Class.
/// </summary>
public partial class Hyperlink
{
  
  /// <summary>
  ///   Hyperlink Target Frame
  /// </summary>
  [SchemaAttr("w:tgtFrame")]
  public String? TargetFrame { get; set; }
  
  
  /// <summary>
  ///   Associated String
  /// </summary>
  [SchemaAttr("w:tooltip")]
  public String? Tooltip { get; set; }
  
  
  /// <summary>
  ///   Location in Target Document
  /// </summary>
  [SchemaAttr("w:docLocation")]
  public String? DocLocation { get; set; }
  
  
  /// <summary>
  ///   Add To Viewed Hyperlinks
  /// </summary>
  [SchemaAttr("w:history")]
  public Boolean? History { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Anchor
  /// </summary>
  [SchemaAttr("w:anchor")]
  public String? Anchor { get; set; }
  
  
  /// <summary>
  ///   Hyperlink Target
  /// </summary>
  [SchemaAttr("r:id")]
  public String? Id { get; set; }
  
  public DocumentModel.ElementCollection<DocumentModel.IModelElement>? Items { get; set; }
  
}
