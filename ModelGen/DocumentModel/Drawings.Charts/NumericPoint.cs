namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Numeric Point.
/// </summary>
public partial class NumericPoint: ModelElement<DXDC.NumericPoint>
{
  public NumericPoint(): base(){ }
  
  public NumericPoint(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumericPoint(DXDC.NumericPoint openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Number Format
  /// </summary>
  [DataMember]
  public String? FormatCode
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FormatCode);
    }
    set
    {
      _ExistingElement.FormatCode = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Numeric Value.
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
