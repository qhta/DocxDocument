namespace DocumentModel.Vml;

/// <summary>
/// This class specifies the defaults that are used when creating new shapes. These defaults are stored once per document.
/// </summary>
public partial class ShapeLayout : ModelElement<DXVO.ShapeLayout>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public ShapeLayout(): base(){ }

  public ShapeLayout(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public ShapeLayout(DXVO.ShapeLayout openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Shape ID Optional Storage.
  /// <para>
  /// Office ignores this value on file read. The value indicates ID blocks of 1024 values, 
  /// where a value of 0 means IDs 0 to 1024, a value of 1 means IDs 1025 to 2048, and so on. 
  /// If Office has at least one shape which has an ID contained in a specific block, it writes out the index for that block.
  /// </para>
  /// </summary>
  [DataMember]
  public DMV.ShapeIdMap? ShapeIdMap
  {
    get => _Element?.GetObject<DMV.ShapeIdMap, DXVO.ShapeIdMap>(); 
    set => _ExistingElement.SetObject<DMV.ShapeIdMap, DXVO.ShapeIdMap>(value); 
  }

  /// <summary>
  /// Office requires that the shape referenced by the idref attribute match the rule type specified by this attribute. 
  /// If the value is arc, idref shall reference a valid shape that is an arc (the value of the shape’s spt attribute is 19). 
  /// If the value is callout, idref shall reference a valid shape that is a callout. 
  /// If the value is connector, idref shall reference a valid shape that is a connector.
  /// </summary>
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
