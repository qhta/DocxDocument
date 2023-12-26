namespace DocumentModel.Drawings;


/// <summary>
///   Text Cap Types
/// </summary>
public partial class TextCapsValues: ModelElement<DXD.TextCapsValues>
{
  public TextCapsValues(): base(){ }
  
  public TextCapsValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TextCapsValues(DXD.TextCapsValues openXmlElement): base(openXmlElement) { }
  
}
