namespace DocumentModel.Office2010.Drawing.Charts;

/// <summary>
/// Defines the InSketchMode Class.
/// </summary>
public interface IInSketchMode // : DocumentFormat.OpenXml.Office2010.Drawing.Charts.BooleanFalseType
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Val { get ; set; }
  
}
