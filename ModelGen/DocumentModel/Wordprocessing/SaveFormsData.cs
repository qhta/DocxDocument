namespace DocumentModel.Wordprocessing;


/// <summary>
///   Only Save Form Field Content.
/// </summary>
public partial class SaveFormsData: ModelElement<DXW.SaveFormsData>
{
  public SaveFormsData(): base(){ }
  
  public SaveFormsData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SaveFormsData(DXW.SaveFormsData openXmlElement): base(openXmlElement) { }
  
}
