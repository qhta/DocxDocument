namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the UnderlineValues enumeration.
/// </summary>
public partial class UnderlineValues: ModelElement<DXW.UnderlineValues>
{
  public UnderlineValues(): base(){ }
  
  public UnderlineValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UnderlineValues(DXW.UnderlineValues openXmlElement): base(openXmlElement) { }
  
}
