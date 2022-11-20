namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the CalculatedMember Class.
/// </summary>
public interface ICalculatedMember // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// measureGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public string? MeasureGroup { get ; set; }
  
  /// <summary>
  /// numberFormat, this property is only available in Office 2013 and later.
  /// </summary>
  public CalculatedMemberNumberFormat? NumberFormat { get ; set; }
  
  /// <summary>
  /// measure, this property is only available in Office 2013 and later.
  /// </summary>
  public bool? Measure { get ; set; }
  
}
