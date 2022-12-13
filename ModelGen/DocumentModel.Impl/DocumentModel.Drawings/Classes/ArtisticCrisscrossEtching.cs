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
  
  public ArtisticCrisscrossEtchingImpl(): base() {}
  
  public ArtisticCrisscrossEtchingImpl(DocumentFormat.OpenXml.Office2010.Drawing.ArtisticCrisscrossEtching openXmlElement): base(openXmlElement)
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
  /// pressure, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Pressure
  {
    get => (System.Int32?)OpenXmlElement?.Pressure?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Pressure = (System.Int32?)value;
    }
  }
  
}
