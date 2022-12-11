namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontSignature Class.
/// </summary>
public class FontSignatureImpl: ModelElementImpl, FontSignature
{
  public DocumentFormat.OpenXml.Wordprocessing.FontSignature? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.FontSignature?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public FontSignatureImpl(): base() {}
  
  public FontSignatureImpl(DocumentFormat.OpenXml.Wordprocessing.FontSignature openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public HexBinaryValue? UnicodeSignature0
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public HexBinaryValue? UnicodeSignature1
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public HexBinaryValue? UnicodeSignature2
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public HexBinaryValue? UnicodeSignature3
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  public HexBinaryValue? CodePageSignature0
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  public HexBinaryValue? CodePageSignature1
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
