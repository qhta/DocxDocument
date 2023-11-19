namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the DataLabelFieldTableEntry Class.
/// </summary>
public partial class DataLabelFieldTableEntry: ModelElement<DXO13DC.DataLabelFieldTableEntry>
{
  public DataLabelFieldTableEntry(): base(){ }
  
  public DataLabelFieldTableEntry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DataLabelFieldTableEntry(DXO13DC.DataLabelFieldTableEntry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TextFieldGuid.
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? TextFieldGuid
  {
    get => _Element?.GetHexIntVal<DXO13DC.TextFieldGuid>();
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
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
  ///   DataLabelFieldTableCache.
  /// </summary>
  [DataMember]
  public DMDC13.DataLabelFieldTableCache? DataLabelFieldTableCache
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2013.Drawing.Chart.StringDataType");
  }
  
}
