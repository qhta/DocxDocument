namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ArtisticPhotocopy Class.
/// </summary>
public partial class ArtisticPhotocopy
{
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("trans")]
  public Int32? Transparancy { get; set; }
  
  
  /// <summary>
  ///   detail, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("detail")]
  public Int32? Detail { get; set; }
  
}
