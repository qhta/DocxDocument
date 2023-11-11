namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of run properties applied to the glyph used to represent the physical location of the paragraph mark for this paragraph. This paragraph mark, being a physical character in the document, can be formatted, and therefore shall be capable of representing this formatting like any other character in the document.
/// </summary>
public partial class PreviousParagraphMarkRunProperties: ModelElement<DXW.PreviousParagraphMarkRunProperties>
{
  public PreviousParagraphMarkRunProperties(): base(){ }
  
  public PreviousParagraphMarkRunProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PreviousParagraphMarkRunProperties(DXW.PreviousParagraphMarkRunProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Inserted Paragraph.
  /// </summary>
  [DataMember]
  public DMW.Inserted? Inserted
  {
    get
    {
      return _Element?.GetObject<DMW.Inserted,DXW.Inserted>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Inserted,DXW.Inserted>(value);
    }
  }
  
  
  /// <summary>
  ///   Deleted Paragraph.
  /// </summary>
  [DataMember]
  public DMW.Deleted? Deleted
  {
    get
    {
      return _Element?.GetObject<DMW.Deleted,DXW.Deleted>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Deleted,DXW.Deleted>(value);
    }
  }
  
  
  /// <summary>
  ///   Move Source Paragraph.
  /// </summary>
  [DataMember]
  public DMW.MoveFrom? MoveFrom
  {
    get
    {
      return _Element?.GetObject<DMW.MoveFrom,DXW.MoveFrom>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MoveFrom,DXW.MoveFrom>(value);
    }
  }
  
  
  /// <summary>
  ///   Move Destination Paragraph.
  /// </summary>
  [DataMember]
  public DMW.MoveTo? MoveTo
  {
    get
    {
      return _Element?.GetObject<DMW.MoveTo,DXW.MoveTo>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.MoveTo,DXW.MoveTo>(value);
    }
  }
  
  [DataMember]
  public DMW10.ConflictInsertion? ConflictInsertion
  {
    get
    {
      return _Element?.GetObject<DMW10.ConflictInsertion,DXO10W.ConflictInsertion>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.ConflictInsertion,DXO10W.ConflictInsertion>(value);
    }
  }
  
  [DataMember]
  public DMW10.ConflictDeletion? ConflictDeletion
  {
    get
    {
      return _Element?.GetObject<DMW10.ConflictDeletion,DXO10W.ConflictDeletion>();
    }
    set
    {
      _ExistingElement.SetObject<DMW10.ConflictDeletion,DXO10W.ConflictDeletion>(value);
    }
  }
  
}
