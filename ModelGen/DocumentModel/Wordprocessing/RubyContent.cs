namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of the guide text within a phonetic guide at the current location in the document.
/// </summary>
public partial class RubyContent: ModelElement<DXW.RubyContent>
{
  public RubyContent(): base(){ }
  
  public RubyContent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RubyContent(DXW.RubyContent openXmlElement): base(openXmlElement) { }
  
}
