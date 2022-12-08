namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticGlowEdges Class.
/// </summary>
public class ArtisticGlowEdgesImpl: ModelElementImpl, ArtisticGlowEdges
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlowEdges?)_OpenXmlElement;
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
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Smoothness
  {
    get;
    set;
  }
  
}
