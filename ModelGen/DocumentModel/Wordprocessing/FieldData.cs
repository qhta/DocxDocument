namespace DocumentModel.Wordprocessing;


/// <summary>
///   Custom Field Data.
/// </summary>
public partial class FieldData: ModelElement<DXW.FieldData>
{
  public FieldData(): base(){ }
  
  public FieldData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FieldData(DXW.FieldData openXmlElement): base(openXmlElement) { }
  
}
