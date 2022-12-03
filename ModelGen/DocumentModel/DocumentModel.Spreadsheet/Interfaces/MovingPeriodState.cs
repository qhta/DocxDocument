namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the MovingPeriodState Class.
/// </summary>
public interface MovingPeriodState // : System.Boolean
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
  public UInt32? ReferenceMultiple { get ; set; }
  
  /// <summary>
  /// movingPeriod, this property is only available in Office 2013 and later.
  /// </summary>
  public MovingPeriodStep? MovingPeriod { get ; set; }
  
  /// <summary>
  /// movingMultiple, this property is only available in Office 2013 and later.
  /// </summary>
  public UInt32? MovingMultiple { get ; set; }
  
}
