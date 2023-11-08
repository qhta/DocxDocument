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
    get
    {
      if (_Element?.UnicodeSignature0?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.UnicodeSignature0.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.UnicodeSignature0 = value.ToString();
      else
        _ExistingElement.UnicodeSignature0 = null;
    }
  }
  
  
  /// <summary>
  ///   Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [DataMember]
  public DM.HexBinary? UnicodeSignature1
  {
    get
    {
      if (_Element?.UnicodeSignature1?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.UnicodeSignature1.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.UnicodeSignature1 = value.ToString();
      else
        _ExistingElement.UnicodeSignature1 = null;
    }
  }
  
  
  /// <summary>
  ///   Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [DataMember]
  public DM.HexBinary? UnicodeSignature2
  {
    get
    {
      if (_Element?.UnicodeSignature2?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.UnicodeSignature2.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.UnicodeSignature2 = value.ToString();
      else
        _ExistingElement.UnicodeSignature2 = null;
    }
  }
  
  
  /// <summary>
  ///   Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  [DataMember]
  public DM.HexBinary? UnicodeSignature3
  {
    get
    {
      if (_Element?.UnicodeSignature3?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.UnicodeSignature3.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.UnicodeSignature3 = value.ToString();
      else
        _ExistingElement.UnicodeSignature3 = null;
    }
  }
  
  
  /// <summary>
  ///   Lower 32 Bits of Code Page Bit Field
  /// </summary>
  [DataMember]
  public DM.HexBinary? CodePageSignature0
  {
    get
    {
      if (_Element?.CodePageSignature0?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.CodePageSignature0.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.CodePageSignature0 = value.ToString();
      else
        _ExistingElement.CodePageSignature0 = null;
    }
  }
  
  
  /// <summary>
  ///   Upper 32 Bits of Code Page Bit Field
  /// </summary>
  [DataMember]
  public DM.HexBinary? CodePageSignature1
  {
    get
    {
      if (_Element?.CodePageSignature1?.Value != null)
        return HexIntConverter.GetValue(_ExistingElement.CodePageSignature1.Value);
      return null;
    }
    set
    {
      if (value != null)
        _ExistingElement.CodePageSignature1 = value.ToString();
      else
        _ExistingElement.CodePageSignature1 = null;
    }
  }
  
}
