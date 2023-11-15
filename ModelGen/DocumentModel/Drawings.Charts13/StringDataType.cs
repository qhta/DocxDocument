namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the StringDataType Class.
/// </summary>
public partial class StringDataType: ModelElement<DXO13DC.StringDataType>
{
  public StringDataType(): base(){ }
  
  public StringDataType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringDataType(DXO13DC.StringDataType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PointCount.
  /// </summary>
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
  }
  
}
