namespace DocumentModel.Wordprocessing;

/// <summary>
/// Numbering Level Starting Value Override.
/// </summary>
public interface IStartOverrideNumberingValue // : DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType
{
  /// <summary>
  /// Decimal Number Value
  /// </summary>
  public int? Val { get ; set; }
  
}
