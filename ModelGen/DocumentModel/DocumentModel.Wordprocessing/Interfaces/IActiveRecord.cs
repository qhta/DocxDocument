namespace DocumentModel.Wordprocessing;

/// <summary>
/// Record Currently Displayed In Merged Document.
/// </summary>
public interface IActiveRecord // : DocumentFormat.OpenXml.Wordprocessing.DecimalNumberType
{
  /// <summary>
  /// Decimal Number Value
  /// </summary>
  public int? Val { get ; set; }
  
}
