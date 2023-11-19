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
  public DocumentModel.HexInt? ProgId
  {
    get => HexIntConverter.GetValue(_Element?.ProgId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   OLE Object Shape
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ShapeId
  {
    get => HexIntConverter.GetValue(_Element?.ShapeId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   OLE Object Unique ID
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ObjectId
  {
    get => HexIntConverter.GetValue(_Element?.ObjectId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Relationship
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
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
