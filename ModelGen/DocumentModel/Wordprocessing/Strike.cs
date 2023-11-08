namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run shall be displayed with a single horizontal line through the center of the line.
/// </summary>
public partial class Strike: ModelElement<DXW.Strike>
{
  public Strike(): base(){ }
  
  public Strike(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Strike(DXW.Strike openXmlElement): base(openXmlElement) { }
  
}
