namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMember Class.
/// </summary>
public interface ICalculatedMember // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// measureGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public String? MeasureGroup { get ; set; }
  
  /// <summary>
  /// numberFormat, this property is only available in Office 2013 and later.
  /// </summary>
  public CalculatedMemberNumberFormat? NumberFormat { get ; set; }
  
  /// <summary>
  /// measure, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? Measure { get ; set; }
  
}
