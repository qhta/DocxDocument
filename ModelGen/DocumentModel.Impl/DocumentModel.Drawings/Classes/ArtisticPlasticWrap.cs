namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticPlasticWrap Class.
/// </summary>
public class ArtisticPlasticWrapImpl: ModelElementImpl, ArtisticPlasticWrap
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticPlasticWrap?)_OpenXmlElement;
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
  /// smoothness, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Smoothness
  {
    get;
    set;
  }
  
}
