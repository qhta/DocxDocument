namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPastelsSmooth Class.
/// </summary>
public partial class ArtisticPastelsSmoothImpl: ModelElementImpl, ArtisticPastelsSmooth
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ArtisticPastelsSmoothImpl(): base() {}
  
  public ArtisticPastelsSmoothImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth openXmlElement): base(openXmlElement)
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
  /// scaling, this property is only available in Office 2010 and later.
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
