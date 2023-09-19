namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ArtisticChalkSketch Class.
/// </summary>
public partial class ArtisticChalkSketch
{
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("trans")]
  public Int32? Transparancy { get; set; }
  
  
  /// <summary>
  ///   pressure, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("pressure")]
  public Int32? Pressure { get; set; }
  
}
