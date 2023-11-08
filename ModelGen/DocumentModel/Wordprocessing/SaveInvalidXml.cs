namespace DocumentModel.Wordprocessing;


/// <summary>
///   Allow Saving Document As XML File When Custom XML Markup Is Invalid.
/// </summary>
public partial class SaveInvalidXml: ModelElement<DXW.SaveInvalidXml>
{
  public SaveInvalidXml(): base(){ }
  
  public SaveInvalidXml(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SaveInvalidXml(DXW.SaveInvalidXml openXmlElement): base(openXmlElement) { }
  
}
