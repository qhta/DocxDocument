namespace DocumentModel.Wordprocessing;


/// <summary>
///   Maintain Link to Existing File.
/// </summary>
public partial class LinkedToFile: ModelElement<DXW.LinkedToFile>
{
  public LinkedToFile(): base(){ }
  
  public LinkedToFile(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LinkedToFile(DXW.LinkedToFile openXmlElement): base(openXmlElement) { }
  
}
