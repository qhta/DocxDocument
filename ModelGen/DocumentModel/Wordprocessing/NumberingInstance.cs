namespace DocumentModel.Wordprocessing;


/// <summary>
///   Numbering Definition Instance.
/// </summary>
public partial class NumberingInstance: ModelElement<DXW.NumberingInstance>
{
  public NumberingInstance(): base(){ }
  
  public NumberingInstance(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberingInstance(DXW.NumberingInstance openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   numId
  /// </summary>
  [DataMember]
  public Int32? NumberID
  {
    get
    {
      return _Element?.NumberID?.Value;
    }
    set
    {
      _ExistingElement.NumberID = value;
    }
  }
  
  
  /// <summary>
  ///   durableId
  /// </summary>
  [DataMember]
  public Int32? DurableId
  {
    get
    {
      return _Element?.DurableId?.Value;
    }
    set
    {
      _ExistingElement.DurableId = value;
    }
  }
  
  
  /// <summary>
  ///   AbstractNumId.
  /// </summary>
  [DataMember]
  public DMW.AbstractNumId? AbstractNumId
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AbstractNumId>();
      if (element != null)
        return AbstractNumIdConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AbstractNumId>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AbstractNumIdConverter.CreateOpenXmlElement<DXW.AbstractNumId>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
