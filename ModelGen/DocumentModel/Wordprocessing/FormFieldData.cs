namespace DocumentModel.Wordprocessing;


/// <summary>
///   Form Field Properties.
/// </summary>
public partial class FormFieldData: ModelElement<DXW.FormFieldData>
{
  public FormFieldData(): base(){ }
  
  public FormFieldData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FormFieldData(DXW.FormFieldData openXmlElement): base(openXmlElement) { }
  
}
