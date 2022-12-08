namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticLightScreen Class.
/// </summary>
public class ArtisticLightScreenImpl: ModelElementImpl, ArtisticLightScreen
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticLightScreen?)_OpenXmlElement;
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
  /// gridSize, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? GridSize
  {
    get;
    set;
  }
  
}
