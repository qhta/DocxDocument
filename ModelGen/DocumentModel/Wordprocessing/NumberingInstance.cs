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
  public DocumentModel.HexInt? NumberID
  {
    get => HexIntConverter.GetValue(_Element?.NumberID);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   durableId
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? DurableId
  {
    get => HexIntConverter.GetValue(_Element?.DurableId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   AbstractNumId.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? AbstractNumId
  {
    get => _Element?.GetHexIntVal<DXW.AbstractNumId>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
