namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPencilGrayscale Class.
/// </summary>
public class ArtisticPencilGrayscaleImpl: ModelElementImpl, ArtisticPencilGrayscale
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale?)_OpenXmlElement;
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
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? BrushSize
  {
    get;
    set;
  }
  
}
