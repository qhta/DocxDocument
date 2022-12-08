namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ArtisticCrisscrossEtching Class.
/// </summary>
public class ArtisticCrisscrossEtchingImpl: ModelElementImpl, ArtisticCrisscrossEtching
{
  public DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching?)_OpenXmlElement;
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
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Pressure
  {
    get;
    set;
  }
  
}
