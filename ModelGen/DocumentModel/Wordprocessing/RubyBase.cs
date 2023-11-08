namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of the base text within a phonetic guide at the current location in the document.
/// </summary>
public partial class RubyBase: ModelElement<DXW.RubyBase>
{
  public RubyBase(): base(){ }
  
  public RubyBase(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RubyBase(DXW.RubyBase openXmlElement): base(openXmlElement) { }
  
}
