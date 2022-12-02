namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the CalculatedMember Class.
/// </summary>
public interface ICalculatedMember // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// measureGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public System.String? MeasureGroup { get ; set; }
  
  /// <summary>
  /// numberFormat, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.CalculatedMemberNumberFormat? NumberFormat { get ; set; }
  
  /// <summary>
  /// measure, this property is only available in Office 2013 and later.
  /// </summary>
  public System.Boolean? Measure { get ; set; }
  
}
