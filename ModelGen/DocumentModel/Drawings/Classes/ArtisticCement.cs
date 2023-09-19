namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ArtisticCement Class.
/// </summary>
public partial class ArtisticCement
{
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("trans")]
  public Int32? Transparancy { get; set; }
  
  
  /// <summary>
  ///   crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("crackSpacing")]
  public Int32? CrackSpacing { get; set; }
  
}
