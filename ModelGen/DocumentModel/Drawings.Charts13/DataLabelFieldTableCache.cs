namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabelFieldTableCache Class.
/// </summary>
public partial class DataLabelFieldTableCache: ModelElement<DXO13DC.DataLabelFieldTableCache>
{
  public DataLabelFieldTableCache(): base(){ }
  
  public DataLabelFieldTableCache(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelFieldTableCache(DXO13DC.DataLabelFieldTableCache openXmlElement): base(openXmlElement) { }
  
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
