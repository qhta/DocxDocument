namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPastelsSmooth Class.
/// </summary>
public class ArtisticPastelsSmoothImpl: ModelElementImpl, ArtisticPastelsSmooth
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPastelsSmooth?)_OpenXmlElement;
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
  public Int32? BrushSize
  {
    get;
    set;
  }
  
}
