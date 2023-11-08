namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TitlePage Class.
/// </summary>
public partial class TitlePage: ModelElement<DXW.TitlePage>
{
  public TitlePage(): base(){ }
  
  public TitlePage(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TitlePage(DXW.TitlePage openXmlElement): base(openXmlElement) { }
  
}
