namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies what type(s) of objects shall automatically labelled with captions (§17.15.1.17), 
/// and with which captions the specified objects shall be labelled as defined in the caption element (§17.15.1.16).
/// </summary>
public partial class AutoCaption: IOpenXmlElementMappedObject
{
  public AutoCaption()
  {
    _Element = new DXW.AutoCaption();
  }

  public AutoCaption(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.AutoCaption)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public AutoCaption(DXW.AutoCaption openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.AutoCaption _Element { get; private set; }

  [DataMember]
  public string? Name
  {
    get => _Element.Name;
    set => _Element.Name = value;
  }

  [DataMember]
  public string? Caption
  {
    get => _Element.Caption;
    set => _Element.Caption = value;
  }
}
