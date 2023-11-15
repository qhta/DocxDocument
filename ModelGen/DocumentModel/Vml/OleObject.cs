namespace DocumentModel.Vml;


/// <summary>
///   Embedded OLE Object.
/// </summary>
public partial class OleObject: ModelElement<DXVO.OleObject>
{
  public OleObject(): base(){ }
  
  public OleObject(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OleObject(DXVO.OleObject openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   OLE Object Application
  /// </summary>
  [DataMember]
  public String? ProgId
  {
    get => _Element?.ProgId;
    set => _ExistingElement.ProgId = value;
  }
  
  
  /// <summary>
  ///   OLE Object Shape
  /// </summary>
  [DataMember]
  public String? ShapeId
  {
    get => _Element?.ShapeId;
    set => _ExistingElement.ShapeId = value;
  }
  
  
  /// <summary>
  ///   OLE Object Unique ID
  /// </summary>
  [DataMember]
  public String? ObjectId
  {
    get => _Element?.ObjectId;
    set => _ExistingElement.ObjectId = value;
  }
  
  
  /// <summary>
  ///   Relationship
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
  
  /// <summary>
  ///   Embedded Object Alternate Image Request.
  /// </summary>
  [DataMember]
  public DMVML.LinkType? LinkType
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   Embedded Object Cannot Be Refreshed.
  /// </summary>
  [DataMember]
  public DMVML.LockedField? LockedField
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
  
  /// <summary>
  ///   WordprocessingML Field Switches.
  /// </summary>
  [DataMember]
  public DMVML.FieldCodes? FieldCodes
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is DocumentFormat.OpenXml.TypedOpenXmlLeafTextElement");
  }
  
}
