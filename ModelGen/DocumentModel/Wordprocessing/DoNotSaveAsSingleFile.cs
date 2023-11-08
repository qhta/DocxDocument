namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DoNotSaveAsSingleFile Class.
/// </summary>
public partial class DoNotSaveAsSingleFile: ModelElement<DXW.DoNotSaveAsSingleFile>
{
  public DoNotSaveAsSingleFile(): base(){ }
  
  public DoNotSaveAsSingleFile(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotSaveAsSingleFile(DXW.DoNotSaveAsSingleFile openXmlElement): base(openXmlElement) { }
  
}
