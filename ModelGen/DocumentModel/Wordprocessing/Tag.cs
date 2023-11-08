namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Tag Class.
/// </summary>
public partial class Tag: ModelElement<DXW.Tag>
{
  public Tag(): base(){ }
  
  public Tag(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Tag(DXW.Tag openXmlElement): base(openXmlElement) { }
  
}
