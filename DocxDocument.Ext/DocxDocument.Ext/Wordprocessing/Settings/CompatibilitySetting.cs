namespace DocumentModel.Wordprocessing;

/// <summary>
/// This class specifies a custom compatibility setting. The semantics for this element are implementation-defined. 
/// <para>
/// [Note: This element can be used to store the transitional compatibility settings specified in Part 4 of /IEC 29500. end note]
/// </para>
/// </summary>
[DataContract]
public partial class CompatibilitySetting : ModelElement<DXW.CompatibilitySetting>, INamedElement
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
  public CompatibilitySetting() : base() { }

  public CompatibilitySetting(DX.OpenXmlElement openXmlElement) : base(openXmlElement) { }

  public CompatibilitySetting(DXW.CompatibilitySetting openXmlElement) : base(openXmlElement) { }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

  /// <summary>
  /// Compatibility setting name.
  /// </summary>
  [DataMember]
  public CompatSettingNameKind? Name
  {
    get => _Element?.Name?.GetEnumValue<DMW.CompatSettingNameKind, DXW.CompatSettingNameValues>();
    set => _ExistingElement.Name = (value == null) ? null :
      EVU.SetEnumValue<DMW.CompatSettingNameKind, DXW.CompatSettingNameValues>(value);
  }

  /// <summary>
  /// Compatibility setting value.
  /// </summary>
  [DataMember]
  public string? Val
  {
    get => _Element?.Val;
    set => _ExistingElement.Val = value;
  }
  string? INamedElement.Name
  {
    get => _Element?.Name?.GetEnumValue<DMW.CompatSettingNameKind, DXW.CompatSettingNameValues>()
      .ToString();
    set => _ExistingElement.Name = (value == null) ? null :
      EVU.SetEnumValue<DMW.CompatSettingNameKind, DXW.CompatSettingNameValues>(Enum.Parse<CompatSettingNameKind>(value));

  }
}
