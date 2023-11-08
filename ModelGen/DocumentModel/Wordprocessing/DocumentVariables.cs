namespace DocumentModel.Wordprocessing;


/// <summary>
///   Document Variables.
/// </summary>
public partial class DocumentVariables: ModelElement<DXW.DocumentVariables>
{
  public DocumentVariables(): base(){ }
  
  public DocumentVariables(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentVariables(DXW.DocumentVariables openXmlElement): base(openXmlElement) { }
  
}
