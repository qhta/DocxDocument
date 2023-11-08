namespace DocumentModel.Wordprocessing;


/// <summary>
///   Endnote Content.
/// </summary>
public partial class Endnote: ModelElement<DXW.Endnote>
{
  public Endnote(): base(){ }
  
  public Endnote(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Endnote(DXW.Endnote openXmlElement): base(openXmlElement) { }
  
}
