namespace DocumentModel.Drawings.SVG;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SVGBlip Class.
/// </summary>
public class SVGBlip: ModelElement
{
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  public string? Embed { get; set; }

  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  public string? Link { get; set; }
}