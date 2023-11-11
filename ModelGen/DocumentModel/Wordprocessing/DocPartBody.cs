namespace DocumentModel.Wordprocessing;


/// <summary>
///   Contents of Glossary Document Entry.
/// </summary>
public partial class DocPartBody: ModelElement<DXW.DocPartBody>
{
  public DocPartBody(): base(){ }
  
  public DocPartBody(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPartBody(DXW.DocPartBody openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMW.SectionProperties? SectionProperties
  {
    get
    {
      return _Element?.GetObject<DMW.SectionProperties,DXW.SectionProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.SectionProperties,DXW.SectionProperties>(value);
    }
  }
  
}
