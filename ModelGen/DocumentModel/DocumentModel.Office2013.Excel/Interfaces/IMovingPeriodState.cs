namespace DocumentModel.Office2013.Excel;

/// <summary>
/// Defines the MovingPeriodState Class.
/// </summary>
public interface IMovingPeriodState // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// referenceDateBegin, this property is only available in Office 2013 and later.
  /// </summary>
  public DateTime? ReferenceDateBegin { get ; set; }
  
  /// <summary>
  /// referencePeriod, this property is only available in Office 2013 and later.
  /// </summary>
  public MovingPeriodStep? ReferencePeriod { get ; set; }
  
  /// <summary>
  /// referenceMultiple, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? ReferenceMultiple { get ; set; }
  
  /// <summary>
  /// movingPeriod, this property is only available in Office 2013 and later.
  /// </summary>
  public MovingPeriodStep? MovingPeriod { get ; set; }
  
  /// <summary>
  /// movingMultiple, this property is only available in Office 2013 and later.
  /// </summary>
  public uint? MovingMultiple { get ; set; }
  
}
