namespace DocumentModel.Wordprocessing;


/// <summary>
///   Line Wrap Trailing Spaces.
/// </summary>
public partial class WrapTrailSpaces: ModelElement<DXW.WrapTrailSpaces>
{
  public WrapTrailSpaces(): base(){ }
  
  public WrapTrailSpaces(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public WrapTrailSpaces(DXW.WrapTrailSpaces openXmlElement): base(openXmlElement) { }
  
}
