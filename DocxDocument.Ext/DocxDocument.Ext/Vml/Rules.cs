namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a list of rule entries which describe how a certain shape or sets of shapes should behave during editing.
/// </summary>
public partial class Rules : IOpenXmlElementMappedObject
{
  public Rules()
  {
    _Element = new DXVO.Rules();
  }

  public Rules(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXVO.Rules)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public Rules(DXVO.Rules openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXVO.Rules _Element { get; private set; }



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
