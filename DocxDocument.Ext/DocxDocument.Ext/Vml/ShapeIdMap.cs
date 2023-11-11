namespace DocumentModel.Vml;

/// <summary>
/// This class specifies how shape IDs in the document have been generated. 
/// This is an optional element included to allow applications a mechanism for storing information 
/// they need to persist related to generating shape IDs.
/// </summary>
public partial class ShapeIdMap : ModelElement<DXVO.ShapeIdMap>
{
  public ShapeIdMap(): base(){ }

  public ShapeIdMap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public ShapeIdMap(DXVO.ShapeIdMap openXmlElement): base(openXmlElement) { } 


  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  [DataMember]
  public string? Data
  {
    get => _Element?.Data?.Value;
    set => _ExistingElement.Data = value;
  }

  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  [DataMember]
  public DMV.ExtensionHandlingBehaviorKind? Extension
  {
    get => _Element?.Extension?.GetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>();
    set => _ExistingElement.Extension = EVU.SetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>(value);
  }

}
