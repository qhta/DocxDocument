namespace DocumentModel.Vml;

/// <summary>
/// This class specifies how shape IDs in the document have been generated. 
/// This is an optional element included to allow applications a mechanism for storing information 
/// they need to persist related to generating shape IDs.
/// </summary>
public partial class ShapeIdMap : IOpenXmlElementMappedObject
{
  public ShapeIdMap()
  {
    _Element = new DXVO.ShapeIdMap();
  }

  public ShapeIdMap(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXVO.ShapeIdMap)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public ShapeIdMap(DXVO.ShapeIdMap openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXVO.ShapeIdMap _Element { get; private set; }


  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  [DataMember]
  public string? Data
  {
    get => _Element.Data?.Value;
    set => _Element.Data = value;
  }

  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  [DataMember]
  public DMV.ExtensionHandlingBehaviorKind? Extension
  {
    get => _Element.Extension?.GetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>();
    set => _Element.Extension = EVU.SetEnumValue<DMV.ExtensionHandlingBehaviorKind, DXV.ExtensionHandlingBehaviorValues>(value);
  }

}
