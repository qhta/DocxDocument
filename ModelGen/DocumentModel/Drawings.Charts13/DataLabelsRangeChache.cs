namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabelsRangeChache Class.
/// </summary>
public partial class DataLabelsRangeChache: ModelElement<DXO13DC.DataLabelsRangeChache>
{
  public DataLabelsRangeChache(): base(){ }
  
  public DataLabelsRangeChache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelsRangeChache(DXO13DC.DataLabelsRangeChache openXmlElement): base(openXmlElement) { }
  
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.UnsignedIntegerType");
  }
  
  [DataMember]
  public DMDC.StrDataExtensionList? StrDataExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
