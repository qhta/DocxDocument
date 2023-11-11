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
      return _Element?.GetObject<DMW.Inserted,DXW.Inserted>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Inserted,DXW.Inserted>(value);
    }
  }
  
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
  
  [DataMember]
  public DMW.TableRowPropertiesChange? TableRowPropertiesChange
  {
    get
    {
      return _Element?.GetObject<DMW.TableRowPropertiesChange,DXW.TableRowPropertiesChange>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableRowPropertiesChange,DXW.TableRowPropertiesChange>(value);
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
