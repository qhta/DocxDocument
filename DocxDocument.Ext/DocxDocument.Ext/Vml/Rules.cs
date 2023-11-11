namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a list of rule entries which describe how a certain shape or sets of shapes should behave during editing.
/// </summary>
public partial class Rules : ModelElement<DXVO.Rules>
{
  public Rules(): base(){ }

  public Rules(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public Rules(DXVO.Rules openXmlElement): base(openXmlElement) { } 

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
