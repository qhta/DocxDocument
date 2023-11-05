namespace DocumentModel.Vml;

/// <summary>
/// This class specifies a rule entry in a rules element rule set that describes how a certain shape or set of shapes 
/// behaves during editing.
/// </summary>
public partial class Entry : IOpenXmlElementMappedObject
{
  public Entry()
  {
    _Element = new DXVO.Entry();
  }

  public Entry(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXVO.Entry)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType : DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
      return validTypeElement;
    throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public Entry(DXVO.Entry openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXVO.Entry _Element { get; private set; }

  /// <summary>
  /// Specifies the ID of the new group. Default is 0.
  /// </summary>
  [DataMember]
  public int? New
  {
    get => _Element.New?.Value;
    set => _Element.New = value;
  }

  /// <summary>
  /// Specifies the ID of the old group. Default is 0.
  /// </summary>
  [DataMember]
  public int? Type
  {
    get => _Element.Old?.Value;
    set => _Element.Old = value;
  }

}
