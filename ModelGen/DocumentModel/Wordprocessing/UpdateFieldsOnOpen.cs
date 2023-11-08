namespace DocumentModel.Wordprocessing;


/// <summary>
///   Automatically Recalculate Fields on Open.
/// </summary>
public partial class UpdateFieldsOnOpen: ModelElement<DXW.UpdateFieldsOnOpen>
{
  public UpdateFieldsOnOpen(): base(){ }
  
  public UpdateFieldsOnOpen(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public UpdateFieldsOnOpen(DXW.UpdateFieldsOnOpen openXmlElement): base(openXmlElement) { }
  
}
