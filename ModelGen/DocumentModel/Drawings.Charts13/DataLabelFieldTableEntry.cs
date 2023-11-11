namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabelFieldTableEntry Class.
/// </summary>
public partial class DataLabelFieldTableEntry: ModelElement<DXO13DC.DataLabelFieldTableEntry>
{
  public DataLabelFieldTableEntry(): base(){ }
  
  public DataLabelFieldTableEntry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelFieldTableEntry(DXO13DC.DataLabelFieldTableEntry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TextFieldGuid.
  /// </summary>
  [DataMember]
  public DMDC13.TextFieldGuid? TextFieldGuid
  {
    get
    {
      return _Element?.GetObject<DMDC13.TextFieldGuid,DXO13DC.TextFieldGuid>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.TextFieldGuid,DXO13DC.TextFieldGuid>(value);
    }
  }
  
  
  /// <summary>
  ///   Formula.
  /// </summary>
  [DataMember]
  public DMDC13.Formula? Formula
  {
    get
    {
      return _Element?.GetObject<DMDC13.Formula,DXO13DC.Formula>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.Formula,DXO13DC.Formula>(value);
    }
  }
  
  
  /// <summary>
  ///   DataLabelFieldTableCache.
  /// </summary>
  [DataMember]
  public DMDC13.DataLabelFieldTableCache? DataLabelFieldTableCache
  {
    get
    {
      return _Element?.GetObject<DMDC13.DataLabelFieldTableCache,DXO13DC.DataLabelFieldTableCache>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.DataLabelFieldTableCache,DXO13DC.DataLabelFieldTableCache>(value);
    }
  }
  
}
