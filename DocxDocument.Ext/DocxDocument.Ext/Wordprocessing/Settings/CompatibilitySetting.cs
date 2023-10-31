namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies a custom compatibility setting. The semantics for this element are implementation-defined. 
/// [Note: This element can be used to store the transitional compatibility settings specified in Part 4 of /IEC 29500. end note]
/// </summary>
public partial class CompatibilitySetting: IOpenXmlElementMappedObject
{
  public CompatibilitySetting()
  {
    _Element = new DXW.CompatibilitySetting();
  }

  public CompatibilitySetting(DX.OpenXmlElement openXmlElement)
  {
    _Element = (DXW.CompatibilitySetting)openXmlElement;
  }

  public OpenXmlElementType GetElement<OpenXmlElementType>() where OpenXmlElementType: DX.OpenXmlElement
  {
    if (_Element is OpenXmlElementType validTypeElement)
    return validTypeElement;
      throw new ArgumentException($"Only {_Element.GetType()} type supported in GetElement of {this.GetType()}");
  }

  public CompatibilitySetting(DXW.CompatibilitySetting openXmlElement)
  {
    _Element = openXmlElement;
  }

  internal DXW.CompatibilitySetting _Element { get; private set; }

  [DataMember]
  public DXW.CompatSettingNameValues Name
  {
    get => _Element.Name ?? default(DXW.CompatSettingNameValues);
    set => _Element.Name = value;
  }

  [DataMember]
  public string? Val
  {
    get => _Element.Val;
    set => _Element.Val = value;
  }
}
