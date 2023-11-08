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
      var element = _Element?.GetFirstChild<DXDC.Formula>();
      if (element != null)
        return FormulaConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Formula>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormulaConverter.CreateOpenXmlElement<DXDC.Formula>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.MultiLevelStringCache>();
      if (element != null)
        return MultiLevelStringCacheConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MultiLevelStringCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MultiLevelStringCacheConverter.CreateOpenXmlElement<DXDC.MultiLevelStringCache>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.MultiLvlStrRefExtensionList>();
      if (element != null)
        return MultiLvlStrRefExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.MultiLvlStrRefExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MultiLvlStrRefExtensionListConverter.CreateOpenXmlElement<DXDC.MultiLvlStrRefExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
