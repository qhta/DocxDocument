namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the TimeUnitType Class.
/// </summary>
public interface ITimeUnitType // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Time Unit Value
  /// </summary>
  public TimeUnitValues? Val { get ; set; }
  
}
