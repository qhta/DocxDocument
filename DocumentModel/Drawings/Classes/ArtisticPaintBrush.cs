namespace DocumentModel.Drawings;

/// <summary>
///   Defines the ArtisticPaintBrush Class.
/// </summary>
public class ArtisticPaintBrush
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }

  /// <summary>
  ///   brushSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BrushSize { get; set; }
}