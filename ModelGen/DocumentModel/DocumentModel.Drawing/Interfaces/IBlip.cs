namespace DocumentModel.Drawing;

/// <summary>
/// Defines the Blip Class.
/// </summary>
public interface IBlip // : DocumentModel.ITypedOpenXmlCompositeElement
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
  public BlipCompressionKind? CompressionState { get ; set; }
  
  public Collection<IAlphaBiLevel>? AlphaBiLevels { get ; set; }
  
  public Collection<Boolean>? AlphaCeilings { get ; set; }
  
  public Collection<Boolean>? AlphaFloors { get ; set; }
  
  public Collection<IAlphaInverse>? AlphaInverses { get ; set; }
  
  public Collection<IAlphaModulationEffect>? AlphaModulationEffects { get ; set; }
  
  public Collection<IAlphaModulationFixed>? AlphaModulationFixeds { get ; set; }
  
  public Collection<IAlphaReplace>? AlphaReplaces { get ; set; }
  
  public Collection<IBiLevel>? BiLevels { get ; set; }
  
  public Collection<IBlur>? Blurs { get ; set; }
  
  public Collection<IColorChange>? ColorChanges { get ; set; }
  
  public Collection<IColorReplacement>? ColorReplacements { get ; set; }
  
  public Collection<IDuotone>? Duotones { get ; set; }
  
  public Collection<IFillOverlay>? FillOverlaies { get ; set; }
  
  public Collection<Boolean>? Grayscales { get ; set; }
  
  public Collection<IHsl>? Hsls { get ; set; }
  
  public Collection<ILuminanceEffect>? LuminanceEffects { get ; set; }
  
  public Collection<ITintEffect>? TintEffects { get ; set; }
  
  public IBlipExtensionList? BlipExtensionList { get ; set; }
  
}
