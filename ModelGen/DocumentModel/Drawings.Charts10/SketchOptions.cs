namespace DocumentModel.Drawings.Charts10;


/// <summary>
///   Defines the SketchOptions Class.
/// </summary>
public partial class SketchOptions: ModelElement<DXO10DC.SketchOptions>
{
  public SketchOptions(): base(){ }
  
  public SketchOptions(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SketchOptions(DXO10DC.SketchOptions openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   InSketchMode.
  /// </summary>
  [DataMember]
  public DMDC10.InSketchMode? InSketchMode
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Drawing.Charts.BooleanFalseType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Office2010.Drawing.Charts.BooleanFalseType");
  }
  
  
  /// <summary>
  ///   ShowSketchButton.
  /// </summary>
  [DataMember]
  public Boolean? ShowSketchButton
  {
    get => _Element?.GetBoolVal<DXO10DC.ShowSketchButton>();
    set => _ExistingElement.SetBoolVal<DXO10DC.ShowSketchButton>(value);
  }
  
}
