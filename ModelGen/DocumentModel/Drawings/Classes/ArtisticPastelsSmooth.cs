namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ArtisticPastelsSmooth Class.
/// </summary>
public partial class ArtisticPastelsSmooth
{
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("trans")]
  public Int32? Transparancy { get; set; }
  
  
  /// <summary>
  ///   scaling, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("scaling")]
  public Int32? BrushSize { get; set; }
  
}
