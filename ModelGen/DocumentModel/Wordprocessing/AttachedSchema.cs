namespace DocumentModel.Wordprocessing;


/// <summary>
///   Attached Custom XML Schema.
/// </summary>
public partial class AttachedSchema: ModelElement<DXW.AttachedSchema>
{
  public AttachedSchema(): base(){ }
  
  public AttachedSchema(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AttachedSchema(DXW.AttachedSchema openXmlElement): base(openXmlElement) { }
  
}
