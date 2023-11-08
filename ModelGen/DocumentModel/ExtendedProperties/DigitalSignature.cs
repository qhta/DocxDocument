namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Digital Signature.
/// </summary>
public partial class DigitalSignature: ModelElement<DXEP.DigitalSignature>
{
  public DigitalSignature(): base(){ }
  
  public DigitalSignature(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DigitalSignature(DXEP.DigitalSignature openXmlElement): base(openXmlElement) { }
  
}
