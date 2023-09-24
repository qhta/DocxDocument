namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ArtisticLineDrawing Class.
/// </summary>
public partial class ArtisticLineDrawing
{
  
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }
  
  
  /// <summary>
  ///   pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? PencilSize { get; set; }
  
}
