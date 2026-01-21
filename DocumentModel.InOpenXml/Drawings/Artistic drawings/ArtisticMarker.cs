namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic marker effect, which simulates a marker drawing style with adjustable transparency and size.
/// </summary>
public partial class ArtisticMarker : ModelElement<DXO10D.ArtisticMarker>
{
  /// <summary>
  /// Transparency level of the marker effect.
  /// </summary>
  public Int32? Transparency { get; set; }
  /// <summary>
  /// Size of the marker used in the effect, influencing the thickness of the strokes.
  /// </summary>
  public Int32? Size { get; set; }
}