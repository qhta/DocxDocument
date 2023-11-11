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
      return _Element?.GetObject<DMW.DocPartProperties,DXW.DocPartProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartProperties,DXW.DocPartProperties>(value);
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
      return _Element?.GetObject<DMW.DocPartBody,DXW.DocPartBody>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocPartBody,DXW.DocPartBody>(value);
    }
  }
  
}
