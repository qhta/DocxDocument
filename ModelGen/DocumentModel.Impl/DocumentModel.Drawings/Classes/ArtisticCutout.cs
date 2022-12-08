namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticCutout Class.
/// </summary>
public class ArtisticCutoutImpl: ModelElementImpl, ArtisticCutout
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCutout?)_OpenXmlElement;
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
  /// numberOfShades, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? NumberOfShades
  {
    get;
    set;
  }
  
}
