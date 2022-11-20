namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Template Code.
/// </summary>
public interface ITemplateCode // : DocumentFormat.OpenXml.Wordprocessing.LongHexNumberType
{
  /// <summary>
  /// Long Hexadecimal Number Value
  /// </summary>
  public IHexBinaryValue? Val { get ; set; }
  
}
