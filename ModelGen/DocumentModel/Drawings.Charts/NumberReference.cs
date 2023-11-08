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
  ///   NumberingCache.
  /// </summary>
  [DataMember]
  public DMDC.NumberingCache? NumberingCache
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.NumberingCache>();
      if (element != null)
        return NumberingCacheConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumberingCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberingCacheConverter.CreateOpenXmlElement<DXDC.NumberingCache>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.NumRefExtensionList>();
      if (element != null)
        return NumRefExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumRefExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumRefExtensionListConverter.CreateOpenXmlElement<DXDC.NumRefExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
