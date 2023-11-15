namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the LevelOverride Class.
/// </summary>
public partial class LevelOverride: ModelElement<DXW.LevelOverride>
{
  public LevelOverride(): base(){ }
  
  public LevelOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LevelOverride(DXW.LevelOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Numbering Level ID
  /// </summary>
  [DataMember]
  public Int32? LevelIndex
  {
    get => _Element?.LevelIndex?.Value;
    set => _ExistingElement.LevelIndex = value;
  }
  
  
  /// <summary>
  ///   Numbering Level Starting Value Override.
  /// </summary>
  [DataMember]
  public DMW.StartOverrideNumberingValue? StartOverrideNumberingValue
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType");
  }
  
  
  /// <summary>
  ///   Numbering Level Override Definition.
  /// </summary>
  [DataMember]
  public DMW.Level? Level
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
