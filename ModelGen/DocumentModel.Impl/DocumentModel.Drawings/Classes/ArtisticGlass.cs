namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticGlass Class.
/// </summary>
public class ArtisticGlassImpl: ModelElementImpl, ArtisticGlass
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticGlass?)_OpenXmlElement;
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
  public Int32? Scaling
  {
    get;
    set;
  }
  
}
