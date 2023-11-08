namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the languages which shall be used to check spelling and grammar (if requested) when processing the contents of this run.
/// </summary>
public partial class Languages: ModelElement<DXW.Languages>
{
  public Languages(): base(){ }
  
  public Languages(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Languages(DXW.Languages openXmlElement): base(openXmlElement) { }
  
}
