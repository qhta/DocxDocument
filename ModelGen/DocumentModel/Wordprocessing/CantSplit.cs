namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CantSplit Class.
/// </summary>
public partial class CantSplit: ModelElement<DXW.CantSplit>
{
  public CantSplit(): base(){ }
  
  public CantSplit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CantSplit(DXW.CantSplit openXmlElement): base(openXmlElement) { }
  
}
