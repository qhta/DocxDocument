namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that all lines of this paragraph should be maintained on a single page whenever possible.
/// </summary>
public partial class KeepLines: ModelElement<DXW.KeepLines>
{
  public KeepLines(): base(){ }
  
  public KeepLines(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public KeepLines(DXW.KeepLines openXmlElement): base(openXmlElement) { }
  
}
