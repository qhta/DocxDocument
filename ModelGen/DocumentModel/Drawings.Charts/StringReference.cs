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
  ///   StringCache.
  /// </summary>
  [DataMember]
  public DMDC.StringCache? StringCache
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.StringCache>();
      if (element != null)
        return StringCacheConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.StringCache>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringCacheConverter.CreateOpenXmlElement<DXDC.StringCache>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.StrRefExtensionList>();
      if (element != null)
        return StrRefExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.StrRefExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrRefExtensionListConverter.CreateOpenXmlElement<DXDC.StrRefExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
