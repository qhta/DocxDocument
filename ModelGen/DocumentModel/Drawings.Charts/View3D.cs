namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D view settings.
/// </summary>
public partial class View3D: ModelElement<DXDC.View3D>
{
  public View3D(): base(){ }
  
  public View3D(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public View3D(DXDC.View3D openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   X Rotation.
  /// </summary>
  [DataMember]
  public SByte? RotateX
  {
    get => _Element?.GetIntVal<SByte, DXDC.RotateX>();
    set => _ExistingElement.SetIntVal<SByte, DXDC.RotateX>(value);
  }
  
  
  /// <summary>
  ///   Height Percent.
  /// </summary>
  [DataMember]
  public UInt16? HeightPercent
  {
    get => _Element?.GetIntVal<UInt16, DXDC.HeightPercent>();
    set => _ExistingElement.SetIntVal<UInt16, DXDC.HeightPercent>(value);
  }
  
  
  /// <summary>
  ///   Y Rotation.
  /// </summary>
  [DataMember]
  public UInt16? RotateY
  {
    get => _Element?.GetIntVal<UInt16, DXDC.RotateY>();
    set => _ExistingElement.SetIntVal<UInt16, DXDC.RotateY>(value);
  }
  
  
  /// <summary>
  ///   Depth Percent.
  /// </summary>
  [DataMember]
  public UInt16? DepthPercent
  {
    get => _Element?.GetIntVal<UInt16, DXDC.DepthPercent>();
    set => _ExistingElement.SetIntVal<UInt16, DXDC.DepthPercent>(value);
  }
  
  
  /// <summary>
  ///   Right Angle Axes.
  /// </summary>
  [DataMember]
  public DMDC.RightAngleAxes? RightAngleAxes
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.Drawing.Charts.BooleanType");
  }
  
  
  /// <summary>
  ///   Perspective.
  /// </summary>
  [DataMember]
  public Byte? Perspective
  {
    get => _Element?.GetIntVal<Byte, DXDC.Perspective>();
    set => _ExistingElement.SetIntVal<Byte, DXDC.Perspective>(value);
  }
  
  
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [DataMember]
  public DMDC.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
