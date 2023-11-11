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
  public DM.NumericValue? NumericValue
  {
    get
    {
      return NumericValueConverter.GetValue(_Element?.NumericValue);
    }
    set
    {
      _ExistingElement.NumericValue = NumericValueConverter.CreateOpenXmlElement<DXDC.NumericValue>(value);
    }
  }
  
}
