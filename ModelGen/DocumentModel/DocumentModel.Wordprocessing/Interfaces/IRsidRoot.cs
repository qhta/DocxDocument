namespace DocumentModel.Wordprocessing;

/// <summary>
/// Original Document Revision Save ID.
/// </summary>
public interface IRsidRoot // : DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType
{
  /// <summary>
  /// Long Hexadecimal Number Value
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}
