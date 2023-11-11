namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Number Reference.
/// </summary>
public partial class NumberReference: ModelElement<DXDC.NumberReference>
{
  public NumberReference(): base(){ }
  
  public NumberReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberReference(DXDC.NumberReference openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Formula.
  /// </summary>
  [DataMember]
  public DMDC.Formula? Formula
  {
    get
    {
      return _Element?.GetObject<DMDC.Formula,DXDC.Formula>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Formula,DXDC.Formula>(value);
    }
  }
  
  
  /// <summary>
  ///   NumberingCache.
  /// </summary>
  [DataMember]
  public DMDC.NumberingCache? NumberingCache
  {
    get
    {
      return _Element?.GetObject<DMDC.NumberingCache,DXDC.NumberingCache>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NumberingCache,DXDC.NumberingCache>(value);
    }
  }
  
  
  /// <summary>
  ///   NumRefExtensionList.
  /// </summary>
  [DataMember]
  public DMDC.NumRefExtensionList? NumRefExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.NumRefExtensionList,DXDC.NumRefExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.NumRefExtensionList,DXDC.NumRefExtensionList>(value);
    }
  }
  
}
