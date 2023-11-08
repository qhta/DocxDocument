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
      var element = _Element?.GetFirstChild<DXW.SectionProperties>();
      if (element != null)
        return SectionPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SectionProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SectionPropertiesConverter.CreateOpenXmlElement<DXW.SectionProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
