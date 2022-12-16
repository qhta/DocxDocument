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
  public DocumentModel.HexBinary? UnicodeSignature0
  {
    get
    {
      if (OpenXmlElement?.UnicodeSignature0?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.UnicodeSignature0.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.UnicodeSignature0 = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.UnicodeSignature0 = null;
      }
    }
  }
  
  /// <summary>
  /// Second 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public DocumentModel.HexBinary? UnicodeSignature1
  {
    get
    {
      if (OpenXmlElement?.UnicodeSignature1?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.UnicodeSignature1.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.UnicodeSignature1 = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.UnicodeSignature1 = null;
      }
    }
  }
  
  /// <summary>
  /// Third 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public DocumentModel.HexBinary? UnicodeSignature2
  {
    get
    {
      if (OpenXmlElement?.UnicodeSignature2?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.UnicodeSignature2.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.UnicodeSignature2 = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.UnicodeSignature2 = null;
      }
    }
  }
  
  /// <summary>
  /// Fourth 32 Bits of Unicode Subset Bitfield
  /// </summary>
  public DocumentModel.HexBinary? UnicodeSignature3
  {
    get
    {
      if (OpenXmlElement?.UnicodeSignature3?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.UnicodeSignature3.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.UnicodeSignature3 = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.UnicodeSignature3 = null;
      }
    }
  }
  
  /// <summary>
  /// Lower 32 Bits of Code Page Bit Field
  /// </summary>
  public DocumentModel.HexBinary? CodePageSignature0
  {
    get
    {
      if (OpenXmlElement?.CodePageSignature0?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.CodePageSignature0.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.CodePageSignature0 = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.CodePageSignature0 = null;
      }
    }
  }
  
  /// <summary>
  /// Upper 32 Bits of Code Page Bit Field
  /// </summary>
  public DocumentModel.HexBinary? CodePageSignature1
  {
    get
    {
      if (OpenXmlElement?.CodePageSignature1?.Value != null)
        return (DocumentModel.HexBinary)OpenXmlElement.CodePageSignature1.Value;
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        if (value != null)
          OpenXmlElement.CodePageSignature1 = new DocumentFormat.OpenXml.HexBinaryValue{ Value = value.ToString() };
        else
          OpenXmlElement.CodePageSignature1 = null;
      }
    }
  }
  
}
