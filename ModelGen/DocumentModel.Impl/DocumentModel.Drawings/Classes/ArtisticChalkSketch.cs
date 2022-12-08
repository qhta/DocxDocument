namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticChalkSketch Class.
/// </summary>
public class ArtisticChalkSketchImpl: ModelElementImpl, ArtisticChalkSketch
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticChalkSketch?)_OpenXmlElement;
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
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Pressure
  {
    get;
    set;
  }
  
}
