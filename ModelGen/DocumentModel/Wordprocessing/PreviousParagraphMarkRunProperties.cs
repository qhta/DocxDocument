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
      var element = _Element?.GetFirstChild<DXW.Inserted>();
      if (element != null)
        return InsertedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Inserted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InsertedConverter.CreateOpenXmlElement<DXW.Inserted>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.Deleted>();
      if (element != null)
        return DeletedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Deleted>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DeletedConverter.CreateOpenXmlElement<DXW.Deleted>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.MoveFrom>();
      if (element != null)
        return MoveFromConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MoveFrom>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveFromConverter.CreateOpenXmlElement<DXW.MoveFrom>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXW.MoveTo>();
      if (element != null)
        return MoveToConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MoveTo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MoveToConverter.CreateOpenXmlElement<DXW.MoveTo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW10.ConflictInsertion? ConflictInsertion
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.ConflictInsertion>();
      if (element != null)
        return ConflictInsertionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.ConflictInsertion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConflictInsertionConverter.CreateOpenXmlElement<DXO10W.ConflictInsertion>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW10.ConflictDeletion? ConflictDeletion
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO10W.ConflictDeletion>();
      if (element != null)
        return ConflictDeletionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10W.ConflictDeletion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ConflictDeletionConverter.CreateOpenXmlElement<DXO10W.ConflictDeletion>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
