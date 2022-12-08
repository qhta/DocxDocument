namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Blip Class.
/// </summary>
public class BlipImpl: ModelElementImpl, Blip
{
  public DocumentFormat.OpenXml.Drawing.Blip? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Blip?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Embedded Picture Reference
  /// </summary>
  public String? Embed
  {
    get;
    set;
  }
  
  /// <summary>
  /// Linked Picture Reference
  /// </summary>
  public String? Link
  {
    get;
    set;
  }
  
  /// <summary>
  /// Compression state for blips.
  /// </summary>
  public BlipCompressionKind? CompressionState
  {
    get => (BlipCompressionKind?)OpenXmlElement?.CompressionState?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompressionState = (DocumentFormat.OpenXml.Drawing.BlipCompressionValues?)value;
    }
  }
  
  public Collection<AlphaBiLevel>? AlphaBiLevels
  {
    get;
    set;
  }
  
  public Collection<Boolean>? AlphaCeilings
  {
    get;
    set;
  }
  
  public Collection<Boolean>? AlphaFloors
  {
    get;
    set;
  }
  
  public Collection<AlphaInverse>? AlphaInverses
  {
    get;
    set;
  }
  
  public Collection<AlphaModulationEffect>? AlphaModulationEffects
  {
    get;
    set;
  }
  
  public Collection<AlphaModulationFixed>? AlphaModulationFixeds
  {
    get;
    set;
  }
  
  public Collection<AlphaReplace>? AlphaReplaces
  {
    get;
    set;
  }
  
  public Collection<BiLevel>? BiLevels
  {
    get;
    set;
  }
  
  public Collection<Blur>? Blurs
  {
    get;
    set;
  }
  
  public Collection<ColorChange>? ColorChanges
  {
    get;
    set;
  }
  
  public Collection<ColorReplacement>? ColorReplacements
  {
    get;
    set;
  }
  
  public Collection<Duotone>? Duotones
  {
    get;
    set;
  }
  
  public Collection<FillOverlay>? FillOverlaies
  {
    get;
    set;
  }
  
  public Collection<Boolean>? Grayscales
  {
    get;
    set;
  }
  
  public Collection<Hsl>? Hsls
  {
    get;
    set;
  }
  
  public Collection<LuminanceEffect>? LuminanceEffects
  {
    get;
    set;
  }
  
  public Collection<TintEffect>? TintEffects
  {
    get;
    set;
  }
  
  public BlipExtensionList? BlipExtensionList
  {
    get;
    set;
  }
  
}
