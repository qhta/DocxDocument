namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the FontSignature Class.
/// </summary>
public partial class FontSignature: ModelElement<DXW.FontSignature>
{
  public FontSignature(): base(){ }
  
  public FontSignature(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FontSignature(DXW.FontSignature openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [DataMember]
  public DM.HexBinary? UnicodeSignature0
  {
    get => HexIntConverter.GetValue(_Element?.UnicodeSignature0);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [DataMember]
  public DM.HexBinary? UnicodeSignature1
  {
    get => HexIntConverter.GetValue(_Element?.UnicodeSignature1);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [DataMember]
  public DM.HexBinary? UnicodeSignature2
  {
    get => HexIntConverter.GetValue(_Element?.UnicodeSignature2);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [DataMember]
  public DM.HexBinary? UnicodeSignature3
  {
    get => HexIntConverter.GetValue(_Element?.UnicodeSignature3);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Lower 32 Bits of Code Page Bit Field
  /// </summary>
  [DataMember]
  public DM.HexBinary? CodePageSignature0
  {
    get => HexIntConverter.GetValue(_Element?.CodePageSignature0);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   Upper 32 Bits of Code Page Bit Field
  /// </summary>
  [DataMember]
  public DM.HexBinary? CodePageSignature1
  {
    get => HexIntConverter.GetValue(_Element?.CodePageSignature1);
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
