namespace DocumentModel.Wordprocessing;


/// <summary>
///   Glossary Document Root Element.
/// </summary>
public partial class GlossaryDocument: ModelElement<DXW.GlossaryDocument>
{
  public GlossaryDocument(): base(){ }
  
  public GlossaryDocument(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GlossaryDocument(DXW.GlossaryDocument openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Document Background.
  /// </summary>
  [DataMember]
  public DMW.DocumentBackground? DocumentBackground
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocumentBackground>();
      if (element != null)
        return DocumentBackgroundConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocumentBackground>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocumentBackgroundConverter.CreateOpenXmlElement<DXW.DocumentBackground>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   List of Glossary Document Entries.
  /// </summary>
  [DataMember]
  public DMW.DocParts? DocParts
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.DocParts>();
      if (element != null)
        return DocPartsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.DocParts>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DocPartsConverter.CreateOpenXmlElement<DXW.DocParts>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
