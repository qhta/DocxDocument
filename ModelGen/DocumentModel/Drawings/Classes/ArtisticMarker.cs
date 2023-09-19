namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ArtisticMarker Class.
/// </summary>
public partial class ArtisticMarker
{
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("trans")]
  public Int32? Transparancy { get; set; }
  
  
  /// <summary>
  ///   size, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("size")]
  public Int32? Size { get; set; }
  
}
