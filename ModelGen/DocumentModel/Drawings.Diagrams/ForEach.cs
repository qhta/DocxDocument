namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   For Each.
/// </summary>
public partial class ForEach: ModelElement<DXDDD.ForEach>
{
  public ForEach(): base(){ }
  
  public ForEach(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ForEach(DXDDD.ForEach openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Reference
  /// </summary>
  [DataMember]
  public String? Reference
  {
    get => _Element?.Reference;
    set => _ExistingElement.Reference = value;
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
  
}
