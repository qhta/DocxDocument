namespace DocumentModel.Vml;

/// <summary>
/// This class specifies the defaults that are used when creating new shapes. These defaults are stored once per document.
/// </summary>
public partial class ShapeLayout : ModelElement<DXVO.ShapeLayout>
{
  public ShapeLayout(): base(){ }

  public ShapeLayout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public ShapeLayout(DXVO.ShapeLayout openXmlElement): base(openXmlElement) { } 

  /// <summary>
  /// Shape ID Optional Storage
  /// </summary>
  [DataMember]
  public DMV.ShapeIdMap? ShapeIdMap
  {
    get => _Element?.GetObject<DMV.ShapeIdMap, DXVO.ShapeIdMap>(); 
    set => _ExistingElement.SetObject<DMV.ShapeIdMap, DXVO.ShapeIdMap>(value); 
  }

  [DataMember]
  public DMV.Rules? Rules
  {
    get => _Element?.GetObject<DMV.Rules, DXVO.Rules>(); 
    set => _ExistingElement.SetObject<DMV.Rules, DXVO.Rules>(value); 
  }

  [DataMember]
  public DMV.RegroupTable? RegroupTable
  {
    get => _Element?.GetObject<DMV.RegroupTable, DXVO.RegroupTable>(); 
    set => _ExistingElement.SetObject<DMV.RegroupTable, DXVO.RegroupTable>(value); 
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
