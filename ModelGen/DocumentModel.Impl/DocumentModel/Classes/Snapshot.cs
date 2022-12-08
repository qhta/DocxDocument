namespace DocumentModel;

/// <summary>
/// Defines the Snapshot Class.
/// </summary>
public class SnapshotImpl: ModelElementImpl, Snapshot
{
  public DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.WebExtension.Snapshot?)_OpenXmlElement;
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
  public DocumentModel.Drawings.BlipCompressionKind? CompressionState
  {
    get => (DocumentModel.Drawings.BlipCompressionKind?)OpenXmlElement?.CompressionState?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CompressionState = (DocumentFormat.OpenXml.Drawing.BlipCompressionValues?)value;
    }
  }
  
  public Collection<DocumentModel.Drawings.AlphaBiLevel>? AlphaBiLevels
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
  
  public Collection<DocumentModel.Drawings.AlphaInverse>? AlphaInverses
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.AlphaModulationEffect>? AlphaModulationEffects
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.AlphaModulationFixed>? AlphaModulationFixeds
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.AlphaReplace>? AlphaReplaces
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.BiLevel>? BiLevels
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.Blur>? Blurs
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.ColorChange>? ColorChanges
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.ColorReplacement>? ColorReplacements
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.Duotone>? Duotones
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.FillOverlay>? FillOverlaies
  {
    get;
    set;
  }
  
  public Collection<Boolean>? Grayscales
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.Hsl>? Hsls
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.LuminanceEffect>? LuminanceEffects
  {
    get;
    set;
  }
  
  public Collection<DocumentModel.Drawings.TintEffect>? TintEffects
  {
    get;
    set;
  }
  
  public DocumentModel.Drawings.BlipExtensionList? BlipExtensionList
  {
    get;
    set;
  }
  
}
