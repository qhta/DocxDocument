namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPencilGrayscale Class.
/// </summary>
public partial class ArtisticPencilGrayscaleImpl: ModelElementImpl, ArtisticPencilGrayscale
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticPencilGrayscaleImpl(): base() {}
  
  public ArtisticPencilGrayscaleImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPencilGrayscale openXmlElement): base(openXmlElement)
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
  public Int32? BrushSize
  {
    get => (System.Int32?)OpenXmlElement?.BrushSize?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.BrushSize = (System.Int32?)value;
    }
  }
  
}
