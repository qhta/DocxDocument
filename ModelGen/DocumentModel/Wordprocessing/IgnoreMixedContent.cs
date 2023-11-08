namespace DocumentModel.Wordprocessing;


/// <summary>
///   Ignore Mixed Content When Validating Custom XML Markup.
/// </summary>
public partial class IgnoreMixedContent: ModelElement<DXW.IgnoreMixedContent>
{
  public IgnoreMixedContent(): base(){ }
  
  public IgnoreMixedContent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public IgnoreMixedContent(DXW.IgnoreMixedContent openXmlElement): base(openXmlElement) { }
  
}
