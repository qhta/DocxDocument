namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the CommentExtensible Class.
/// </summary>
public partial class CommentExtensible: ModelElement<DXO21WCE.CommentExtensible>
{
  public CommentExtensible(): base(){ }
  
  public CommentExtensible(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentExtensible(DXO21WCE.CommentExtensible openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   durableId, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public DM.HexBinary? DurableId
  {
    get
    {
      if (_Element?.DurableId?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.DurableId.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.DurableId = value.ToString();
      else
        _ExistingElement.DurableId = null;
    }
  }
  
  
  /// <summary>
  ///   dateUtc, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public DateTime? DateUtc
  {
    get
    {
      return _Element?.DateUtc?.Value;
    }
    set
    {
      _ExistingElement.DateUtc = value;
    }
  }
  
  
  /// <summary>
  ///   intelligentPlaceholder, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public Boolean? IntelligentPlaceholder
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.IntelligentPlaceholder);
    }
    set
    {
      _ExistingElement.IntelligentPlaceholder = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMW.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21WCE.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21WCE.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO21WCE.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
