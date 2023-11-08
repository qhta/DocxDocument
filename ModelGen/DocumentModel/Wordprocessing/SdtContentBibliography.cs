namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be of type bibliography.
/// </summary>
public partial class SdtContentBibliography: ModelElement<DXW.SdtContentBibliography>
{
  public SdtContentBibliography(): base(){ }
  
  public SdtContentBibliography(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentBibliography(DXW.SdtContentBibliography openXmlElement): base(openXmlElement) { }
  
}
