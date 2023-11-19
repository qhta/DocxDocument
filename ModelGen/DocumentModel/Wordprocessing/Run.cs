namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a run of content in the parent field, hyperlink, custom XML element, structured document tag, smart tag, or paragraph.
/// </summary>
public partial class Run: ModelElement<DXW.Run>
{
  public Run(): base(){ }
  
  public Run(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Run(DXW.Run openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Revision Identifier for Run Properties
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidRunProperties
  {
    get => HexIntConverter.GetValue(_Element?.RsidRunProperties);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Revision Identifier for Run Deletion
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidRunDeletion
  {
    get => HexIntConverter.GetValue(_Element?.RsidRunDeletion);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Revision Identifier for Run
  /// </summary>
  [DataMember]
  public DM.HexBinary? RsidRunAddition
  {
    get => HexIntConverter.GetValue(_Element?.RsidRunAddition);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Run Properties.
  /// </summary>
  [DataMember]
  public DMW.RunProperties? RunProperties
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
