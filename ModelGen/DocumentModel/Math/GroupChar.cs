namespace DocumentModel.Math;


/// <summary>
///   Group-Character Function.
/// </summary>
public partial class GroupChar: ModelElement<DXM.GroupChar>
{
  public GroupChar(): base(){ }
  
  public GroupChar(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupChar(DXM.GroupChar openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Group-Character Properties.
  /// </summary>
  [DataMember]
  public DMM.GroupCharProperties? GroupCharProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.GroupCharProperties>();
      if (element != null)
        return GroupCharPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.GroupCharProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = GroupCharPropertiesConverter.CreateOpenXmlElement<DXM.GroupCharProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Base>();
      if (element != null)
        return BaseConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BaseConverter.CreateOpenXmlElement<DXM.Base>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
