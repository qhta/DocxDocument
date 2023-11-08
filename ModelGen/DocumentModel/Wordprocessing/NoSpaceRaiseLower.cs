namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Increase Line Height for Raised/Lowered Text.
/// </summary>
public partial class NoSpaceRaiseLower: ModelElement<DXW.NoSpaceRaiseLower>
{
  public NoSpaceRaiseLower(): base(){ }
  
  public NoSpaceRaiseLower(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoSpaceRaiseLower(DXW.NoSpaceRaiseLower openXmlElement): base(openXmlElement) { }
  
}
