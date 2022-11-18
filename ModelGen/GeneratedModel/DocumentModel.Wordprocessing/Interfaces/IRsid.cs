namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Session Revision Save ID.
/// </summary>
public interface IRsid // : DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType
{
  /// <summary>
  /// Long Hexadecimal Number Value
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}
