namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all locking properties for a connection shape. These properties inform the generating application about specific properties that have been previously locked and thus should not be changed.
/// </summary>
public partial class GroupShapeLocks: ModelElement<DXD.GroupShapeLocks>
{
  public GroupShapeLocks(): base(){ }
  
  public GroupShapeLocks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GroupShapeLocks(DXD.GroupShapeLocks openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot be grouped. That is it cannot be combined within other shapes to form a group of shapes. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoGrouping
  {
    get => _Element?.NoGrouping?.Value;
    set => _ExistingElement.NoGrouping = value;
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not show adjust handles for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoUngrouping
  {
    get => _Element?.NoUngrouping?.Value;
    set => _ExistingElement.NoUngrouping = value;
  }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot have any part of it be selected. That means that no picture, shapes or attached text can be selected either if this attribute has been specified. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoSelection
  {
    get => _Element?.NoSelection?.Value;
    set => _ExistingElement.NoSelection = value;
  }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot be rotated Objects that reside within the group can still be rotated unless they also have been locked. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoRotation
  {
    get => _Element?.NoRotation?.Value;
    set => _ExistingElement.NoRotation = value;
  }
  
  
  /// <summary>
  ///   Disallow Aspect Ratio Change
  /// </summary>
  [DataMember]
  public Boolean? NoChangeAspect
  {
    get => _Element?.NoChangeAspect?.Value;
    set => _ExistingElement.NoChangeAspect = value;
  }
  
  
  /// <summary>
  ///   Specifies that the corresponding graphic frame cannot be moved. Objects that reside within the graphic frame can still be moved unless they also have been locked. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoMove
  {
    get => _Element?.NoMove?.Value;
    set => _ExistingElement.NoMove = value;
  }
  
  
  /// <summary>
  ///   Specifies that the corresponding group shape cannot be resized. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoResize
  {
    get => _Element?.NoResize?.Value;
    set => _ExistingElement.NoResize = value;
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMD.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.OpenXmlCompositeElement");
  }
  
}
