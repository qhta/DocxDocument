namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies that a BLIP should be stretched to fill the target rectangle. The other option is a tile where a BLIP is tiled to fill the available area.
/// </summary>
public partial class Stretch
{
  
  /// <summary>
  ///   Fill Rectangle.
  /// </summary>
  public RelativeRectangleType? FillRectangle { get; set; }
  
}
