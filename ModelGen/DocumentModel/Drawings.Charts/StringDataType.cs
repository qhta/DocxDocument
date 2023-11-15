namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the StringDataType Class.
/// </summary>
public partial class StringDataType: ModelElement<DXDC.StringDataType>
{
  public StringDataType(): base(){ }
  
  public StringDataType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StringDataType(DXDC.StringDataType openXmlElement): base(openXmlElement) { }
  
  
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
