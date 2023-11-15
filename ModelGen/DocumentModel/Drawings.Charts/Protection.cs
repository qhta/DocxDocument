namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the Protection Class.
/// </summary>
public partial class Protection: ModelElement<DXDC.Protection>
{
  public Protection(): base(){ }
  
  public Protection(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Protection(DXDC.Protection openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Chart Object.
  /// </summary>
  [DataMember]
  public DMDC.ChartObject? ChartObject
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Data Cannot Be Changed.
  /// </summary>
  [DataMember]
  public DMDC.Data? Data
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Formatting.
  /// </summary>
  [DataMember]
  public DMDC.Formatting? Formatting
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Selection.
  /// </summary>
  [DataMember]
  public DMDC.Selection? Selection
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   User Interface.
  /// </summary>
  [DataMember]
  public DMDC.UserInterface? UserInterface
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
}
