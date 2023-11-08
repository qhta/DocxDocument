namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a unique four digit number which shall be used to determine the editing session in which this style definition was last modified. This value shall follow this following constraint: All document elements which specify the same rsid* values shall correspond to changes made during the same editing session. An editing session is defined as the period of editing which takes place between any two subsequent save actions.
/// </summary>
public partial class Rsid: ModelElement<DXW.Rsid>
{
  public Rsid(): base(){ }
  
  public Rsid(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Rsid(DXW.Rsid openXmlElement): base(openXmlElement) { }
  
}
