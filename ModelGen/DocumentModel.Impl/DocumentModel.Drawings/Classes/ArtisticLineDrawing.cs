namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticLineDrawing Class.
/// </summary>
public class ArtisticLineDrawingImpl: ModelElementImpl, ArtisticLineDrawing
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing?)_OpenXmlElement;
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
  public Int32? PencilSize
  {
    get;
    set;
  }
  
}
