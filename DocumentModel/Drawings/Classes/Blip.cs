namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Blip Class.
/// </summary>
public partial class Blip
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public String? Embed { get; set; }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public String? Link { get; set; }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public DocumentModel.Drawings.BlipCompressionKind? CompressionState { get; set; }
  
  public DocumentModel.Drawings.AlphaBiLevel? AlphaBiLevel { get; set; }
  
  public Boolean? AlphaCeiling { get; set; }
  
  public Boolean? AlphaFloor { get; set; }
  
  public DocumentModel.Drawings.AlphaInverse? AlphaInverse { get; set; }
  
  public DocumentModel.Drawings.AlphaModulationEffect? AlphaModulationEffect { get; set; }
  
  public DocumentModel.Drawings.AlphaModulationFixed? AlphaModulationFixed { get; set; }
  
  public DocumentModel.Drawings.AlphaReplace? AlphaReplace { get; set; }
  
  public DocumentModel.Drawings.BiLevel? BiLevel { get; set; }
  
  public DocumentModel.Drawings.Blur? Blur { get; set; }
  
  public DocumentModel.Drawings.ColorChange? ColorChange { get; set; }
  
  public DocumentModel.Drawings.ColorReplacement? ColorReplacement { get; set; }
  
  public DocumentModel.Drawings.Duotone? Duotone { get; set; }
  
  public DocumentModel.Drawings.FillOverlay? FillOverlay { get; set; }
  
  public Boolean? Grayscale { get; set; }
  
  public DocumentModel.Drawings.Hsl? Hsl { get; set; }
  
  public DocumentModel.Drawings.LuminanceEffect? LuminanceEffect { get; set; }
  
  public DocumentModel.Drawings.TintEffect? TintEffect { get; set; }
  
  public DocumentModel.Drawings.BlipExtensionList? BlipExtensionList { get; set; }
  
}
