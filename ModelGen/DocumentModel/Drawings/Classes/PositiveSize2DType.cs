namespace DocumentModel.Drawings;


/// <summary>
///   Defines the PositiveSize2DType Class.
/// </summary>
public partial class PositiveSize2DType
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
