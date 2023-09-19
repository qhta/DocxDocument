namespace DocumentModel.Drawings.SVG;


/// <summary>
///   Defines the SVGBlip Class.
/// </summary>
public partial class SVGBlip
{
  
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  [SchemaAttr("r:embed")]
  public String? Embed { get; set; }
  
  
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  [SchemaAttr("r:link")]
  public String? Link { get; set; }
  
}
