namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StringReference Class.
/// </summary>
public partial class StringReference: ModelElement<DXDC.StringReference>
{
  public StringReference(): base(){ }
  
  public StringReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringReference(DXDC.StringReference openXmlElement): base(openXmlElement) { }
  
  
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
  ///   StringCache.
  /// </summary>
  [DataMember]
  public DMDC.StringCache? StringCache
  {
    get
    {
      return _Element?.GetObject<DMDC.StringCache,DXDC.StringCache>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StringCache,DXDC.StringCache>(value);
    }
  }
  
  
  /// <summary>
  ///   StrRefExtensionList.
  /// </summary>
  [DataMember]
  public DMDC.StrRefExtensionList? StrRefExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.StrRefExtensionList,DXDC.StrRefExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.StrRefExtensionList,DXDC.StrRefExtensionList>(value);
    }
  }
  
}
