namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DivsType Class.
/// </summary>
public partial class DivsType: ModelElement<DXW.DivsType>
{
  public DivsType(): base(){ }
  
  public DivsType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DivsType(DXW.DivsType openXmlElement): base(openXmlElement) { }
  
}
