namespace DocumentModel.Wordprocessing;


/// <summary>
///   Recalculate Fields When Current Field Is Modified.
/// </summary>
public partial class CalculateOnExit: ModelElement<DXW.CalculateOnExit>
{
  public CalculateOnExit(): base(){ }
  
  public CalculateOnExit(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CalculateOnExit(DXW.CalculateOnExit openXmlElement): base(openXmlElement) { }
  
}
