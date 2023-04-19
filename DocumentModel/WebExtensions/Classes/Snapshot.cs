using DocumentModel.Drawings;

namespace DocumentModel.WebExtensions;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the Snapshot Class.
/// </summary>
public class Snapshot: ModelElement
{
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  public string? Embed { get; set; }

  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  public string? Link { get; set; }

  /// <summary>
  ///   Compression state for blips.
  /// </summary>
  public BlipCompressionKind? CompressionState { get; set; }

  public AlphaBiLevel? AlphaBiLevel { get; set; }

  public bool? AlphaCeiling { get; set; }

  public bool? AlphaFloor { get; set; }

  public AlphaInverse? AlphaInverse { get; set; }

  public AlphaModulationEffect? AlphaModulationEffect { get; set; }

  public AlphaModulationFixed? AlphaModulationFixed { get; set; }

  public AlphaReplace? AlphaReplace { get; set; }

  public BiLevel? BiLevel { get; set; }

  public Blur? Blur { get; set; }

  public ColorChange? ColorChange { get; set; }

  public ColorReplacement? ColorReplacement { get; set; }

  public Duotone? Duotone { get; set; }

  public FillOverlay? FillOverlay { get; set; }

  public Boolean Grayscale { get; set; }

  public Hsl? Hsl { get; set; }

  public LuminanceEffect? LuminanceEffect { get; set; }

  public TintEffect? TintEffect { get; set; }

  public BlipExtensionList? BlipExtensionList { get; set; }
}