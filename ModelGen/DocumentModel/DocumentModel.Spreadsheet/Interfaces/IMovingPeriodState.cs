namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MovingPeriodState Class.
/// </summary>
public interface IMovingPeriodState // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// referenceDateBegin, this property is only available in Office 2013 and later.
  /// </summary>
  public System.DateTime? ReferenceDateBegin { get ; set; }
  
  /// <summary>
  /// referencePeriod, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.MovingPeriodStep? ReferencePeriod { get ; set; }
  
  /// <summary>
  /// referenceMultiple, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? ReferenceMultiple { get ; set; }
  
  /// <summary>
  /// movingPeriod, this property is only available in Office 2013 and later.
  /// </summary>
  public DocumentModel.Spreadsheet.MovingPeriodStep? MovingPeriod { get ; set; }
  
  /// <summary>
  /// movingMultiple, this property is only available in Office 2013 and later.
  /// </summary>
  public System.UInt32? MovingMultiple { get ; set; }
  
}
