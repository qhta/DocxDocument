namespace DocumentModel.Wordprocessing;

/// <summary>
/// Abstract Numbering Definition Identifier.
/// </summary>
public interface INsid // : DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType
{
  /// <summary>
  /// Long Hexadecimal Number Value
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}
