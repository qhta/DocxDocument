namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Total Number of Characters.
/// </summary>
public partial class Characters: ModelElement<DXEP.Characters>
{
  public Characters(): base(){ }
  
  public Characters(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Characters(DXEP.Characters openXmlElement): base(openXmlElement) { }
  
}
