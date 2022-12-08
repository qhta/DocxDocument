namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticCement Class.
/// </summary>
public class ArtisticCementImpl: ModelElementImpl, ArtisticCement
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCement?)_OpenXmlElement;
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
  /// crackSpacing, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? CrackSpacing
  {
    get;
    set;
  }
  
}
