namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Center Content on Lines With Exact Line Height.
/// </summary>
public partial class NoExtraLineSpacing: ModelElement<DXW.NoExtraLineSpacing>
{
  public NoExtraLineSpacing(): base(){ }
  
  public NoExtraLineSpacing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NoExtraLineSpacing(DXW.NoExtraLineSpacing openXmlElement): base(openXmlElement) { }
  
}
