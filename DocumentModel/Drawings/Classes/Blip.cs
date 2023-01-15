namespace DocumentModel.Drawings;

/// <summary>
///   Defines the Blip Class.
/// </summary>
public class Blip
{
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  public String? Embed { get; set; }

  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  public String? Link { get; set; }

  /// <summary>
  ///   Compression state for blips.
  /// </summary>
  public BlipCompressionKind? CompressionState { get; set; }

  public AlphaBiLevel? AlphaBiLevel { get; set; }

  public Boolean? AlphaCeiling { get; set; }

  public Boolean? AlphaFloor { get; set; }

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

  public Boolean? Grayscale { get; set; }

  public Hsl? Hsl { get; set; }

  public LuminanceEffect? LuminanceEffect { get; set; }

  public TintEffect? TintEffect { get; set; }

  public BlipExtensionList? BlipExtensionList { get; set; }
}