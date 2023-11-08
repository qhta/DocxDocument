namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the name of the document part that shall be displayed in the nearest ancestor structured document tag when its run contents are empty. If this element is specified, then a document part whose name element specifies a name matching the value of this element, and which belongs to the bbPlcHdr style shall be located to be used as the placeholder text for the nearest ancestor structured document tag.
/// </summary>
public partial class DocPart: ModelElement<DXW.DocPart>
{
  public DocPart(): base(){ }
  
  public DocPart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocPart(DXW.DocPart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Glossary Document Entry Properties.
  /// </summary>
  [DataMember]
  public DMW.DocPartProperties? DocPartProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocPartProperties>();
      if (element != null)
        return DocPartPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocPartProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartPropertiesConverter.CreateOpenXmlElement<DXW.DocPartProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Contents of Glossary Document Entry.
  /// </summary>
  [DataMember]
  public DMW.DocPartBody? DocPartBody
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocPartBody>();
      if (element != null)
        return DocPartBodyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocPartBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartBodyConverter.CreateOpenXmlElement<DXW.DocPartBody>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
