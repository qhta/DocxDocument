namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Bypass East Asian/Complex Script Layout Code.
/// </summary>
public partial class UseFarEastLayout: ModelElement<DXW.UseFarEastLayout>
{
  public UseFarEastLayout(): base(){ }
  
  public UseFarEastLayout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UseFarEastLayout(DXW.UseFarEastLayout openXmlElement): base(openXmlElement) { }
  
}
