namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ExternalData Class.
/// </summary>
public partial class ExternalData: ModelElement<DXDC.ExternalData>
{
  public ExternalData(): base(){ }
  
  public ExternalData(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ExternalData(DXDC.ExternalData openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relationship Reference
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Update Automatically.
  /// </summary>
  [DataMember]
  public DMDC.AutoUpdate? AutoUpdate
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
}
