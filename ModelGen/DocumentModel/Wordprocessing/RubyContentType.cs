namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the RubyContentType Class.
/// </summary>
public partial class RubyContentType: ModelElement<DXW.RubyContentType>
{
  public RubyContentType(): base(){ }
  
  public RubyContentType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RubyContentType(DXW.RubyContentType openXmlElement): base(openXmlElement) { }
  
}
