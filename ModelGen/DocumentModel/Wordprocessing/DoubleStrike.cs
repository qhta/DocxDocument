namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this run shall be displayed with two horizontal lines through each character displayed on the line.
/// </summary>
public partial class DoubleStrike: ModelElement<DXW.DoubleStrike>
{
  public DoubleStrike(): base(){ }
  
  public DoubleStrike(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoubleStrike(DXW.DoubleStrike openXmlElement): base(openXmlElement) { }
  
}
