namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies a custom compatibility setting. The semantics for this element are implementation-defined. 
/// [Note: This element can be used to store the transitional compatibility settings specified in Part 4 of /IEC 29500. end note]
/// </summary>
[DataContract]
public partial class CompatibilitySetting: ModelElement<DXW.CompatibilitySetting>, INamedElement
{
  public CompatibilitySetting(): base(){ }

  public CompatibilitySetting(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public CompatibilitySetting(DXW.CompatibilitySetting openXmlElement): base(openXmlElement) { }

  [DataMember]
  public string? Name
  {
    get => (_Element?.Name?.GetEnumValue<DMW.CompatSettingNameKind, DXW.CompatSettingNameValues>() 
      ?? default(DMW.CompatSettingNameKind)).ToString();
    set => _ExistingElement.Name = (value==null) ? null :
      EVU.SetEnumValue<DMW.CompatSettingNameKind, DXW.CompatSettingNameValues>(Enum.Parse<DMW.CompatSettingNameKind>(value));
  }

  [DataMember]
  public string? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
}
