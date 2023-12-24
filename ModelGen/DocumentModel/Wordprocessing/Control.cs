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
  public String? ShapeId
  {
    get => _Element?.ShapeId;
    set => _ExistingElement.ShapeId = value;
  }
  
  
  /// <summary>
  ///   Embedded Control Properties Relationship Reference
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
}
