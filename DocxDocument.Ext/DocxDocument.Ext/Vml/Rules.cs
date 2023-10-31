namespace DocumentModel.Vml;

/// <summary>
/// This element specifies a list of rule entries which describe how a certain shape or sets of shapes should behave during editing.
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
  public DXV.ExtensionHandlingBehaviorValues? Extension
  {
    get => _Element.Extension?.Value;
    set => _Element.Extension = value;
  }

}
