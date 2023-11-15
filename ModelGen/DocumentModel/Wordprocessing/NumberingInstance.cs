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
    get => _Element?.NumberID?.Value;
    set => _ExistingElement.NumberID = value;
  }
  
  
  /// <summary>
  ///   durableId
  /// </summary>
  [DataMember]
  public Int32? DurableId
  {
    get => _Element?.DurableId?.Value;
    set => _ExistingElement.DurableId = value;
  }
  
  
  /// <summary>
  ///   AbstractNumId.
  /// </summary>
  [DataMember]
  public DMW.AbstractNumId? AbstractNumId
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.NonNegativeDecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.NonNegativeDecimalNumberType");
  }
  
}
