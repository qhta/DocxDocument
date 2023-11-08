namespace DocumentModel.Wordprocessing;


/// <summary>
///   Date Block - Long Day Format.
/// </summary>
public partial class DayLong: ModelElement<DXW.DayLong>
{
  public DayLong(): base(){ }
  
  public DayLong(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DayLong(DXW.DayLong openXmlElement): base(openXmlElement) { }
  
}
