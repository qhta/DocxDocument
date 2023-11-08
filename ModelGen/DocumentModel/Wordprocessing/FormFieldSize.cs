namespace DocumentModel.Wordprocessing;


/// <summary>
///   Checkbox Form Field Size.
/// </summary>
public partial class FormFieldSize: ModelElement<DXW.FormFieldSize>
{
  public FormFieldSize(): base(){ }
  
  public FormFieldSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FormFieldSize(DXW.FormFieldSize openXmlElement): base(openXmlElement) { }
  
}
