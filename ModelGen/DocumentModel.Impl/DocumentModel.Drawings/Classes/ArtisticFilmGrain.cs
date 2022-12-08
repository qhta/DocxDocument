namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticFilmGrain Class.
/// </summary>
public class ArtisticFilmGrainImpl: ModelElementImpl, ArtisticFilmGrain
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticFilmGrain?)_OpenXmlElement;
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
  /// grainSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? GrainSize
  {
    get;
    set;
  }
  
}
