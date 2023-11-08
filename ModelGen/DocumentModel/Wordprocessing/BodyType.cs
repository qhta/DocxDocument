namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BodyType Class.
/// </summary>
public partial class BodyType: ModelElement<DXW.BodyType>
{
  public BodyType(): base(){ }
  
  public BodyType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BodyType(DXW.BodyType openXmlElement): base(openXmlElement) { }
  
}
