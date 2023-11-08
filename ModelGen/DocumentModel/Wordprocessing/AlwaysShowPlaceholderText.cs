namespace DocumentModel.Wordprocessing;


/// <summary>
///   Use Custom XML Element Names as Default Placeholder Text.
/// </summary>
public partial class AlwaysShowPlaceholderText: ModelElement<DXW.AlwaysShowPlaceholderText>
{
  public AlwaysShowPlaceholderText(): base(){ }
  
  public AlwaysShowPlaceholderText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AlwaysShowPlaceholderText(DXW.AlwaysShowPlaceholderText openXmlElement): base(openXmlElement) { }
  
}
