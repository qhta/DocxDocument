namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the AltName Class.
/// </summary>
public partial class AltName: ModelElement<DXW.AltName>
{
  public AltName(): base(){ }
  
  public AltName(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AltName(DXW.AltName openXmlElement): base(openXmlElement) { }
  
}
