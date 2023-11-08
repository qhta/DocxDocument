namespace DocumentModel.Wordprocessing;


/// <summary>
///   Field Code.
/// </summary>
public partial class FieldCode: ModelElement<DXW.FieldCode>
{
  public FieldCode(): base(){ }
  
  public FieldCode(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FieldCode(DXW.FieldCode openXmlElement): base(openXmlElement) { }
  
}
