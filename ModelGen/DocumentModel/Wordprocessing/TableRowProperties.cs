namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of row-level properties applied to the current table row. Each unique property is specified by a child element of this element. These properties affect the appearance of all cells in the current row within the parent table but can be overridden by individual cell-level properties, as defined by each property.
/// </summary>
public partial class TableRowProperties: ModelElement<DXW.TableRowProperties>
{
  public TableRowProperties(): base(){ }
  
  public TableRowProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableRowProperties(DXW.TableRowProperties openXmlElement): base(openXmlElement) { }
  
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
  
  [DataMember]
  public DMW.TableRowPropertiesChange? TableRowPropertiesChange
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableRowPropertiesChange>();
      if (element != null)
        return TableRowPropertiesChangeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableRowPropertiesChange>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableRowPropertiesChangeConverter.CreateOpenXmlElement<DXW.TableRowPropertiesChange>(value);
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
