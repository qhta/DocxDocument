namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DoNotOrganizeInFolder Class.
/// </summary>
public partial class DoNotOrganizeInFolder: ModelElement<DXW.DoNotOrganizeInFolder>
{
  public DoNotOrganizeInFolder(): base(){ }
  
  public DoNotOrganizeInFolder(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotOrganizeInFolder(DXW.DoNotOrganizeInFolder openXmlElement): base(openXmlElement) { }
  
}
