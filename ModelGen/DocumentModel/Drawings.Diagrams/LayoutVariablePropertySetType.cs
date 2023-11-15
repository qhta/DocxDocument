namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Defines the LayoutVariablePropertySetType Class.
/// </summary>
public partial class LayoutVariablePropertySetType: ModelElement<DXDDD.LayoutVariablePropertySetType>
{
  public LayoutVariablePropertySetType(): base(){ }
  
  public LayoutVariablePropertySetType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LayoutVariablePropertySetType(DXDDD.LayoutVariablePropertySetType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Show Organization Chart User Interface.
  /// </summary>
  [DataMember]
  public Boolean? OrganizationChart
  {
    get => _Element?.GetBoolVal<DXDDD.OrganizationChart>();
    set => _ExistingElement.SetBoolVal<DXDDD.OrganizationChart>(value);
  }
  
  
  /// <summary>
  ///   Maximum Children.
  /// </summary>
  [DataMember]
  public Int32? MaxNumberOfChildren
  {
    get => _Element?.GetIntVal<Int32, DXDDD.MaxNumberOfChildren>();
    set => _ExistingElement.SetIntVal<Int32, DXDDD.MaxNumberOfChildren>(value);
  }
  
  
  /// <summary>
  ///   Preferred Number of Children.
  /// </summary>
  [DataMember]
  public Int32? PreferredNumberOfChildren
  {
    get => _Element?.GetIntVal<Int32, DXDDD.PreferredNumberOfChildren>();
    set => _ExistingElement.SetIntVal<Int32, DXDDD.PreferredNumberOfChildren>(value);
  }
  
  
  /// <summary>
  ///   Show Insert Bullet.
  /// </summary>
  [DataMember]
  public Boolean? BulletEnabled
  {
    get => _Element?.GetBoolVal<DXDDD.BulletEnabled>();
    set => _ExistingElement.SetBoolVal<DXDDD.BulletEnabled>(value);
  }
  
  
  /// <summary>
  ///   Diagram Direction.
  /// </summary>
  [DataMember]
  public DMDD.DirectionKind? Direction
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Organization Chart Branch Style.
  /// </summary>
  [DataMember]
  public DMDD.HierarchyBranchStyleKind? HierarchyBranch
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   One by One Animation String.
  /// </summary>
  [DataMember]
  public DMDD.AnimateOneByOneKind? AnimateOneByOne
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Level Animation.
  /// </summary>
  [DataMember]
  public DMDD.AnimationLevelStringKind? AnimationLevel
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
  
  /// <summary>
  ///   Shape Resize Style.
  /// </summary>
  [DataMember]
  public DMDD.ResizeHandlesStringKind? ResizeHandles
  {
    get => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertyGetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
    set => throw new NotImplementedException("Not implemented in GenerateEnumTypePropertySetCode: enum propertyType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafElement");
  }
  
}
