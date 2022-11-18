namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the DataField Class.
/// </summary>
public interface IDataField // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// pivotShowAs, this property is only available in Office 2010 and later.
  /// </summary>
  public PivotShowAs? PivotShowAs { get ; set; }
  
  /// <summary>
  /// sourceField, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? SourceField { get ; set; }
  
  /// <summary>
  /// uniqueName, this property is only available in Office 2010 and later.
  /// </summary>
  public string? UniqueName { get ; set; }
  
}
