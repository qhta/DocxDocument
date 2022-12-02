namespace DocumentModel;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public interface ISnapshot // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public String? Embed { get ; set; }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public String? Link { get ; set; }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public DocumentModel.Drawing.BlipCompressionKind? CompressionState { get ; set; }
  
  public Collection<DocumentModel.Drawing.IAlphaBiLevel>? AlphaBiLevels { get ; set; }
  
  public Collection<Boolean>? AlphaCeilings { get ; set; }
  
  public Collection<Boolean>? AlphaFloors { get ; set; }
  
  public Collection<DocumentModel.Drawing.IAlphaInverse>? AlphaInverses { get ; set; }
  
  public Collection<DocumentModel.Drawing.IAlphaModulationEffect>? AlphaModulationEffects { get ; set; }
  
  public Collection<DocumentModel.Drawing.IAlphaModulationFixed>? AlphaModulationFixeds { get ; set; }
  
  public Collection<DocumentModel.Drawing.IAlphaReplace>? AlphaReplaces { get ; set; }
  
  public Collection<DocumentModel.Drawing.IBiLevel>? BiLevels { get ; set; }
  
  public Collection<DocumentModel.Drawing.IBlur>? Blurs { get ; set; }
  
  public Collection<DocumentModel.Drawing.IColorChange>? ColorChanges { get ; set; }
  
  public Collection<DocumentModel.Drawing.IColorReplacement>? ColorReplacements { get ; set; }
  
  public Collection<DocumentModel.Drawing.IDuotone>? Duotones { get ; set; }
  
  public Collection<DocumentModel.Drawing.IFillOverlay>? FillOverlaies { get ; set; }
  
  public Collection<Boolean>? Grayscales { get ; set; }
  
  public Collection<DocumentModel.Drawing.IHsl>? Hsls { get ; set; }
  
  public Collection<DocumentModel.Drawing.ILuminanceEffect>? LuminanceEffects { get ; set; }
  
  public Collection<DocumentModel.Drawing.ITintEffect>? TintEffects { get ; set; }
  
  public DocumentModel.Drawing.IBlipExtensionList? BlipExtensionList { get ; set; }
  
}
