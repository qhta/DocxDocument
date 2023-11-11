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
      return _Element?.GetObject<DMW.DocumentBackground,DXW.DocumentBackground>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocumentBackground,DXW.DocumentBackground>(value);
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
      return _Element?.GetObject<DMW.DocParts,DXW.DocParts>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.DocParts,DXW.DocParts>(value);
    }
  }
  
}
