namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definitions.
/// </summary>
public partial class Numbering: ModelElement<DXW.Numbering>
{
  public Numbering(): base(){ }
  
  public Numbering(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Numbering(DXW.Numbering openXmlElement): base(openXmlElement) { }
  
}
