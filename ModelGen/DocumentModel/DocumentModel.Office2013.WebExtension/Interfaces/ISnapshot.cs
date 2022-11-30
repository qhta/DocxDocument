namespace DocumentModel.Office2013.WebExtension;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public interface ISnapshot // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public System.String? Embed { get ; set; }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public System.String? Link { get ; set; }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public DocumentModel.Drawing.BlipCompressionKind? CompressionState { get ; set; }
  
  public DocumentModel.Drawing.IAlphaBiLevel? AlphaBiLevel { get ; set; }
  
  public System.Boolean? AlphaCeiling { get ; set; }
  
  public System.Boolean? AlphaFloor { get ; set; }
  
  public DocumentModel.Drawing.IAlphaInverse? AlphaInverse { get ; set; }
  
  public DocumentModel.Drawing.IAlphaModulationEffect? AlphaModulationEffect { get ; set; }
  
  public DocumentModel.Drawing.IAlphaModulationFixed? AlphaModulationFixed { get ; set; }
  
  public DocumentModel.Drawing.IAlphaReplace? AlphaReplace { get ; set; }
  
  public DocumentModel.Drawing.IBiLevel? BiLevel { get ; set; }
  
  public DocumentModel.Drawing.IBlur? Blur { get ; set; }
  
  public DocumentModel.Drawing.IColorChange? ColorChange { get ; set; }
  
  public DocumentModel.Drawing.IColorReplacement? ColorReplacement { get ; set; }
  
  public DocumentModel.Drawing.IDuotone? Duotone { get ; set; }
  
  public DocumentModel.Drawing.IFillOverlay? FillOverlay { get ; set; }
  
  public System.Boolean? Grayscale { get ; set; }
  
  public DocumentModel.Drawing.IHsl? Hsl { get ; set; }
  
  public DocumentModel.Drawing.ILuminanceEffect? LuminanceEffect { get ; set; }
  
  public DocumentModel.Drawing.ITintEffect? TintEffect { get ; set; }
  
  public DocumentModel.Drawing.IBlipExtensionList? BlipExtensionList { get ; set; }
  
}
