namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ArtisticPencilGrayscale Class.
/// </summary>
public partial class ArtisticPencilGrayscale
{
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("trans")]
  public Int32? Transparancy { get; set; }
  
  
  /// <summary>
  ///   pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  [SchemaAttr("pencilSize")]
  public Int32? BrushSize { get; set; }
  
}
