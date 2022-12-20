namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticLineDrawing Class.
/// </summary>
public partial class ArtisticLineDrawingImpl: ModelElementImpl, ArtisticLineDrawing
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ArtisticLineDrawingImpl(): base() {}
  
  public ArtisticLineDrawingImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLineDrawing openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// trans, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Transparancy
  {
    get => (System.Int32?)OpenXmlElement?.Transparancy?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Transparancy = (System.Int32?)value;
    }
  }
  
  /// <summary>
  /// pencilSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? PencilSize
  {
    get => (System.Int32?)OpenXmlElement?.PencilSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PencilSize = (System.Int32?)value;
    }
  }
  
}
