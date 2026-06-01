namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ArtisticPaintBrush Class.
/// </summary>
public class ArtisticPaintBrush: ModelElement
{
  /// <summary>
  ///   trans, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? Transparancy { get; set; }

  /// <summary>
  ///   brushSize, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public Int32? BrushSize { get; set; }
}
