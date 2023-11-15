namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies all locking properties for a graphic frame. These properties inform the generating application about specific properties that have been previously locked and thus should not be changed.
/// </summary>
public partial class PictureLocks: ModelElement<DXD.PictureLocks>
{
  public PictureLocks(): base(){ }
  
  public PictureLocks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PictureLocks(DXD.PictureLocks openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape grouping for the corresponding connection shape. That is it cannot be combined within other shapes to form a group of shapes. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoGrouping
  {
    get => _Element?.NoGrouping?.Value;
    set => _ExistingElement.NoGrouping = value;
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow selecting of the corresponding connection shape. That means also that no picture, shapes or text attached to this connection shape can be selected if this attribute has been specified. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoSelection
  {
    get => _Element?.NoSelection?.Value;
    set => _ExistingElement.NoSelection = value;
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape rotation changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
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
  ///   Specifies that the generating application should not allow position changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoMove
  {
    get => _Element?.NoMove?.Value;
    set => _ExistingElement.NoMove = value;
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow size changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoResize
  {
    get => _Element?.NoResize?.Value;
    set => _ExistingElement.NoResize = value;
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape point changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoEditPoints
  {
    get => _Element?.NoEditPoints?.Value;
    set => _ExistingElement.NoEditPoints = value;
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not show adjust handles for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoAdjustHandles
  {
    get => _Element?.NoAdjustHandles?.Value;
    set => _ExistingElement.NoAdjustHandles = value;
  }
  
  
  /// <summary>
  ///   Disallow Arrowhead Changes
  /// </summary>
  [DataMember]
  public Boolean? NoChangeArrowheads
  {
    get => _Element?.NoChangeArrowheads?.Value;
    set => _ExistingElement.NoChangeArrowheads = value;
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow shape type changes for the corresponding connection shape. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoChangeShapeType
  {
    get => _Element?.NoChangeShapeType?.Value;
    set => _ExistingElement.NoChangeShapeType = value;
  }
  
  
  /// <summary>
  ///   Specifies that the generating application should not allow cropping for the corresponding picture. If this attribute is not specified, then a value of false is assumed.
  /// </summary>
  [DataMember]
  public Boolean? NoCrop
  {
    get => _Element?.NoCrop?.Value;
    set => _ExistingElement.NoCrop = value;
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
