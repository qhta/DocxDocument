namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticTexturizer Class.
/// </summary>
public class ArtisticTexturizerImpl: ModelElementImpl, ArtisticTexturizer
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticTexturizer?)_OpenXmlElement;
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
  /// scaling, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Scaling
  {
    get;
    set;
  }
  
}
