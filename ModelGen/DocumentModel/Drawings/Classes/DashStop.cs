namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies a dash stop primitive. Dashing schemes are built by specifying an ordered list of dash stop primitive. A dash stop primitive consists of a dash and a space.
/// </summary>
public partial class DashStop
{
  
  /// <summary>
  ///   Specifies the length of the dash relative to the line width.
  /// </summary>
  [SchemaAttr("d")]
  public Int32? DashLength { get; set; }
  
  
  /// <summary>
  ///   Specifies the length of the space relative to the line width.
  /// </summary>
  [SchemaAttr("sp")]
  public Int32? SpaceLength { get; set; }
  
}
