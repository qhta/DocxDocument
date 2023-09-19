namespace DocumentModel.Drawings.Wordprocessing;


/// <summary>
///   Inline Drawing Object Extents.
/// </summary>
public partial class Extent
{
  
  /// <summary>
  ///   Extent Length
  /// </summary>
  [SchemaAttr("cx")]
  public Int64? Cx { get; set; }
  
  
  /// <summary>
  ///   Extent Width
  /// </summary>
  [SchemaAttr("cy")]
  public Int64? Cy { get; set; }
  
}
