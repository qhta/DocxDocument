namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NumericLevel Class.
/// </summary>
public interface NumericLevel // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// ptCount, this property is only available in Office 2016 and later.
  /// </summary>
  public UInt32? PtCount { get ; set; }
  
  /// <summary>
  /// formatCode, this property is only available in Office 2016 and later.
  /// </summary>
  public String? FormatCode { get ; set; }
  
  /// <summary>
  /// name, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Name { get ; set; }
  
  public Collection<NumericValue>? NumericValues { get ; set; }
  
}
