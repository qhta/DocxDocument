namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the NumericValue Class.
/// </summary>
public partial class NumericValue: ModelElement<DXO16DCD.NumericValue>
{
  public NumericValue(): base(){ }
  
  public NumericValue(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumericValue(DXO16DCD.NumericValue openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? Idx
  {
    get
    {
      return _Element?.Idx?.Value;
    }
    set
    {
      _ExistingElement.Idx = value;
    }
  }
  
}
