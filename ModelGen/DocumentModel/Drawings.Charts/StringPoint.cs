namespace DocumentModel.Drawings.Charts;


/// <summary>
///   String Point.
/// </summary>
public partial class StringPoint: ModelElement<DXDC.StringPoint>
{
  public StringPoint(): base(){ }
  
  public StringPoint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringPoint(DXDC.StringPoint openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index
  /// </summary>
  [DataMember]
  public UInt32? Index
  {
    get
    {
      return _Element?.Index?.Value;
    }
    set
    {
      _ExistingElement.Index = value;
    }
  }
  
  
  /// <summary>
  ///   Text Value.
  /// </summary>
  [DataMember]
  public DMDC.NumericValue? NumericValue
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.NumericValue>();
      if (element != null)
        return NumericValueConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumericValue>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumericValueConverter.CreateOpenXmlElement<DXDC.NumericValue>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
