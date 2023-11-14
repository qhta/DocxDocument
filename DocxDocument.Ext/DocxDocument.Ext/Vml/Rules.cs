namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a list of rule entries which describe how a certain shape or sets of shapes should behave during editing.
/// </summary>
public partial class Rules : NamedElementCollection<DXVO.Rules, DXVO.Rule, DMV.Rule>
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public Rules(): base(){ }

  public Rules(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Rules(DXVO.Rules openXmlElement): base(openXmlElement) { } 
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

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
