namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies a custom compatibility setting. The semantics for this element are implementation-defined. 
/// [Note: This element can be used to store the transitional compatibility settings specified in Part 4 of /IEC 29500. end note]
/// </summary>
[DataContract]
public partial class CompatibilitySetting: ModelElement<DXW.CompatibilitySetting>
{
  public CompatibilitySetting(): base(){ }

  public CompatibilitySetting(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }

  public CompatibilitySetting(DXW.CompatibilitySetting openXmlElement): base(openXmlElement) { }

  [DataMember]
  public DMW.CompatSettingNameKind Name
  {
    get => _Element.Name?.GetEnumValue<DMW.CompatSettingNameKind, DXW.CompatSettingNameValues>() ?? default(DMW.CompatSettingNameKind);
    set => _Element.Name = EVU.SetEnumValue<DMW.CompatSettingNameKind, DXW.CompatSettingNameValues>(value);
  }

  [DataMember]
  public string? Val
  {
    get => _Element.Val;
    set => _Element.Val = value;
  }
}
