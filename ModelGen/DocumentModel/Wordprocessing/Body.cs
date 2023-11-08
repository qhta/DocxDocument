namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the contents of the body of the document - the main document editing surface.
/// </summary>
public partial class Body: ModelElement<DXW.Body>
{
  public Body(): base(){ }
  
  public Body(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Body(DXW.Body openXmlElement): base(openXmlElement) { }
  
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
