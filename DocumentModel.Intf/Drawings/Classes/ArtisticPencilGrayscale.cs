namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ArtisticPencilGrayscale Class.
/// </summary>
public class ArtisticPencilGrayscale: ModelElement
{
  /// <summary>
  ///   trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }

  /// <summary>
  ///   pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BrushSize { get; set; }
}