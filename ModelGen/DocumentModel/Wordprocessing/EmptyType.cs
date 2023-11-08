namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the EmptyType Class.
/// </summary>
public partial class EmptyType: ModelElement<DXW.EmptyType>
{
  public EmptyType(): base(){ }
  
  public EmptyType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public EmptyType(DXW.EmptyType openXmlElement): base(openXmlElement) { }
  
}
