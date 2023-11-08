namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Show Visual Indicator For Invalid Custom XML Markup.
/// </summary>
public partial class DoNotDemarcateInvalidXml: ModelElement<DXW.DoNotDemarcateInvalidXml>
{
  public DoNotDemarcateInvalidXml(): base(){ }
  
  public DoNotDemarcateInvalidXml(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DoNotDemarcateInvalidXml(DXW.DoNotDemarcateInvalidXml openXmlElement): base(openXmlElement) { }
  
}
