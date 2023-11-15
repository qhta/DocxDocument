namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all locking properties for a graphic frame. These properties inform the generating application about specific properties that have been previously locked and thus should not be changed.
/// </summary>
public partial class GraphicFrameLocks: ModelElement<DXD.GraphicFrameLocks>
{
  public GraphicFrameLocks(): base(){ }
  
  public GraphicFrameLocks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GraphicFrameLocks(DXD.GraphicFrameLocks openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape grouping for the corresponding graphic frame. That is it cannot be combined within other shapes to form a group of shapes. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoGrouping
  {
    get => _Element?.NoGrouping?.Value;
    set => _ExistingElement.NoGrouping = value;
  }
  
  
  /// <summary>
  ///   Disallow Selection of Child Shapes
  /// </summary>
  [DataMember]
  public Boolean? NoDrilldown
  {
    get => _Element?.NoDrilldown?.Value;
    set => _ExistingElement.NoDrilldown = value;
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow selecting of the corresponding picture. That means also that no picture, shapes or text attached to this picture can be selected if this attribute has been specified. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoSelection
  {
    get => _Element?.NoSelection?.Value;
    set => _ExistingElement.NoSelection = value;
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
  ///   Specifies that the generating application should not allow size changes for the corresponding graphic frame. If this attribute is not specified, then a value of false is assumed.
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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
