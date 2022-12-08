namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticGlowDiffused Class.
/// </summary>
public class ArtisticGlowDiffusedImpl: ModelElementImpl, ArtisticGlowDiffused
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowDiffused?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy
  {
    get;
    set;
  }
  
  /// <summary>
  /// intensity, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Intensity
  {
    get;
    set;
  }
  
}
