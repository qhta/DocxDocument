namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPaintStrokes Class.
/// </summary>
public class ArtisticPaintStrokesImpl: ModelElementImpl, ArtisticPaintStrokes
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPaintStrokes?)_OpenXmlElement;
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
