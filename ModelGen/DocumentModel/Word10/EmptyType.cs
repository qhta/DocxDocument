namespace DocumentModel.Word10;


/// <summary>
///   Defines the EmptyType Class.
/// </summary>
public partial class EmptyType: ModelElement<DXO10W.EmptyType>
{
  public EmptyType(): base(){ }
  
  public EmptyType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmptyType(DXO10W.EmptyType openXmlElement): base(openXmlElement) { }
  
}
