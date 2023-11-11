namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Multi Level String Reference.
/// </summary>
public partial class MultiLevelStringReference: ModelElement<DXDC.MultiLevelStringReference>
{
  public MultiLevelStringReference(): base(){ }
  
  public MultiLevelStringReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MultiLevelStringReference(DXDC.MultiLevelStringReference openXmlElement): base(openXmlElement) { }
  
  
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
  ///   MultiLevelStringCache.
  /// </summary>
  [DataMember]
  public DMDC.MultiLevelStringCache? MultiLevelStringCache
  {
    get
    {
      return _Element?.GetObject<DMDC.MultiLevelStringCache,DXDC.MultiLevelStringCache>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MultiLevelStringCache,DXDC.MultiLevelStringCache>(value);
    }
  }
  
  
  /// <summary>
  ///   MultiLvlStrRefExtensionList.
  /// </summary>
  [DataMember]
  public DMDC.MultiLvlStrRefExtensionList? MultiLvlStrRefExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.MultiLvlStrRefExtensionList,DXDC.MultiLvlStrRefExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.MultiLvlStrRefExtensionList,DXDC.MultiLvlStrRefExtensionList>(value);
    }
  }
  
}
