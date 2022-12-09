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
  
  /// <summary>
  /// First 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public DocumentModel.HexBinaryValue? UnicodeSignature0
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public DocumentModel.HexBinaryValue? UnicodeSignature1
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public DocumentModel.HexBinaryValue? UnicodeSignature2
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public DocumentModel.HexBinaryValue? UnicodeSignature3
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  public DocumentModel.HexBinaryValue? CodePageSignature0
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  public DocumentModel.HexBinaryValue? CodePageSignature1
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
