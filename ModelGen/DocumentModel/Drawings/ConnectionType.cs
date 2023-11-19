namespace DocumentModel.Drawings;


/// <summary>
///   Defines the ConnectionType Class.
/// </summary>
public partial class ConnectionType: ModelElement<DXD.ConnectionType>
{
  public ConnectionType(): base(){ }
  
  public ConnectionType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ConnectionType(DXD.ConnectionType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Identifier
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Index
  /// </summary>
  [DataMember]
  public UInt32? Index
  {
    get => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertyGetCode: numeric propertyType baseType is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
    set => throw new NotImplementedException("Not implemented in GenerateNumericValuePropertySetCode: numeric propertyType baseclass is DocumentFormat.OpenXml.OpenXmlComparableSimpleValue`1[System.UInt32]");
  }
  
}
