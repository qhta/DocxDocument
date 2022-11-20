namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the ArtisticLineDrawing Class.
/// </summary>
public class ArtisticLineDrawing: IArtisticLineDrawing
{
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public int? Transparancy
  {
    get;
    set;
  }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public int? PencilSize
  {
    get;
    set;
  }
  
}
