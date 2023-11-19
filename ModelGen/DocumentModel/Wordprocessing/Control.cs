namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the Control Class.
/// </summary>
public partial class Control: ModelElement<DXW.Control>
{
  public Control(): base(){ }
  
  public Control(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Control(DXW.Control openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Unique Name for Embedded Control
  /// </summary>
  [DataMember]
  public String? Name
  {
    get => _Element?.Name;
    set => _ExistingElement.Name = value;
  }
  
  
  /// <summary>
  ///   Associated VML Data Reference
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? ShapeId
  {
    get => HexIntConverter.GetValue(_Element?.ShapeId);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Embedded Control Properties Relationship Reference
  /// </summary>
  [DataMember]
  public DocumentModel.HexInt? Id
  {
    get => HexIntConverter.GetValue(_Element?.Id);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
