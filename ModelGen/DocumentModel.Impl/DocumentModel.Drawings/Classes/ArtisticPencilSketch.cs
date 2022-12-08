namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPencilSketch Class.
/// </summary>
public class ArtisticPencilSketchImpl: ModelElementImpl, ArtisticPencilSketch
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilSketch?)_OpenXmlElement;
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
