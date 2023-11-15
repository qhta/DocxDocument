namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ContentPartLocks Class.
/// </summary>
public partial class ContentPartLocks: ModelElement<DXO10D.ContentPartLocks>
{
  public ContentPartLocks(): base(){ }
  
  public ContentPartLocks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ContentPartLocks(DXO10D.ContentPartLocks openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Disallow Shape Grouping
  /// </summary>
  [DataMember]
  public Boolean? NoGrouping
  {
    get => _Element?.NoGrouping?.Value;
    set => _ExistingElement.NoGrouping = value;
  }
  
  
  /// <summary>
  ///   Disallow Shape Selection
  /// </summary>
  [DataMember]
  public Boolean? NoSelection
  {
    get => _Element?.NoSelection?.Value;
    set => _ExistingElement.NoSelection = value;
  }
  
  
  /// <summary>
  ///   Disallow Shape Rotation
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
  ///   Disallow Shape Movement
  /// </summary>
  [DataMember]
  public Boolean? NoMove
  {
    get => _Element?.NoMove?.Value;
    set => _ExistingElement.NoMove = value;
  }
  
  
  /// <summary>
  ///   Disallow Shape Resize
  /// </summary>
  [DataMember]
  public Boolean? NoResize
  {
    get => _Element?.NoResize?.Value;
    set => _ExistingElement.NoResize = value;
  }
  
  
  /// <summary>
  ///   Disallow Shape Point Editing
  /// </summary>
  [DataMember]
  public Boolean? NoEditPoints
  {
    get => _Element?.NoEditPoints?.Value;
    set => _ExistingElement.NoEditPoints = value;
  }
  
  
  /// <summary>
  ///   Disallow Showing Adjust Handles
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
  ///   Disallow Shape Type Change
  /// </summary>
  [DataMember]
  public Boolean? NoChangeShapeType
  {
    get => _Element?.NoChangeShapeType?.Value;
    set => _ExistingElement.NoChangeShapeType = value;
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMD10.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlCompositeElement");
  }
  
}
