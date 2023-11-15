namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   If.
/// </summary>
public partial class DiagramChooseIf: ModelElement<DXDDD.DiagramChooseIf>
{
  public DiagramChooseIf(): base(){ }
  
  public DiagramChooseIf(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DiagramChooseIf(DXDDD.DiagramChooseIf openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Name
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Axis
  /// </summary>
  [DataMember]
  public DM.ListOf<AxisKind>? Axis
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Data Point Type
  /// </summary>
  [DataMember]
  public DM.ListOf<ElementKind>? PointType
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Hide Last Transition
  /// </summary>
  [DataMember]
  public DM.ListOf<Boolean>? HideLastTrans
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Start
  /// </summary>
  [DataMember]
  public DM.ListOf<Int32>? Start
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Count
  /// </summary>
  [DataMember]
  public DM.ListOf<UInt32>? Count
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Step
  /// </summary>
  [DataMember]
  public DM.ListOf<Int32>? Step
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.Object");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.Object");
  }
  
  
  /// <summary>
  ///   Argument
  /// </summary>
  [DataMember]
  public String? Argument
  {
    get => _Element?.Argument;
    set => _ExistingElement.Argument = value;
  }
  
  
  /// <summary>
  ///   Value
  /// </summary>
  [DataMember]
  public String? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  
}
