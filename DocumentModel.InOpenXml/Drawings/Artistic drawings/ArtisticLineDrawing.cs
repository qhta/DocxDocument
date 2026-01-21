namespace DocumentModel.Drawings;
/// <summary>
/// Represents an artistic line drawing effect, which simulates a hand-drawn line style with adjustable transparency and pencil size.
/// </summary>
public partial class ArtisticLineDrawing : ModelElement<DXO10D.ArtisticLineDrawing>
{
  /// <summary>
  /// Transparency level of the line drawing effect.
  /// </summary>
  public Int32? Transparency { get; set; }
  /// <summary>
  /// Size of the pencil used in the line drawing effect, influencing the thickness of the lines.
  /// </summary>
  public Int32? PencilSize { get; set; }
}