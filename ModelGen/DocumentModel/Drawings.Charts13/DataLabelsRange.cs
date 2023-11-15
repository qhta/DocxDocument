namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabelsRange Class.
/// </summary>
public partial class DataLabelsRange: ModelElement<DXO13DC.DataLabelsRange>
{
  public DataLabelsRange(): base(){ }
  
  public DataLabelsRange(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelsRange(DXO13DC.DataLabelsRange openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Formula.
  /// </summary>
  [DataMember]
  public DMDC13.Formula? Formula
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   DataLabelsRangeChache.
  /// </summary>
  [DataMember]
  public DMDC13.DataLabelsRangeChache? DataLabelsRangeChache
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType");
  }
  
}
