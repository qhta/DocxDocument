namespace DocumentModel.Wordprocessing;


/// <summary>
///   Predefined Merge Field Name.
/// </summary>
public partial class MappedName: ModelElement<DXW.MappedName>
{
  public MappedName(): base(){ }
  
  public MappedName(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MappedName(DXW.MappedName openXmlElement): base(openXmlElement) { }
  
}
