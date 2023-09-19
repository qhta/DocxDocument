namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an alpha outset/inset effect.
/// </summary>
public partial class AlphaOutset
{
  
  /// <summary>
  ///   Specifies the radius of outset/inset.
  /// </summary>
  [SchemaAttr("rad")]
  public Int64? Radius { get; set; }
  
}
