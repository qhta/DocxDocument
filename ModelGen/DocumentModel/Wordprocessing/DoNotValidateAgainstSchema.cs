namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Validate Custom XML Markup Against Schemas.
/// </summary>
public partial class DoNotValidateAgainstSchema: ModelElement<DXW.DoNotValidateAgainstSchema>
{
  public DoNotValidateAgainstSchema(): base(){ }
  
  public DoNotValidateAgainstSchema(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotValidateAgainstSchema(DXW.DoNotValidateAgainstSchema openXmlElement): base(openXmlElement) { }
  
}
