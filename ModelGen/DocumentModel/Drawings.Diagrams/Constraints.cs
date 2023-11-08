namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Constraint List.
/// </summary>
public partial class Constraints: ModelElement<DXDDD.Constraints>
{
  public Constraints(): base(){ }
  
  public Constraints(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Constraints(DXDDD.Constraints openXmlElement): base(openXmlElement) { }
  
}
