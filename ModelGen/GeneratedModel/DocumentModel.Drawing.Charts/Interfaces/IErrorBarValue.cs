namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Error Bar Value.
/// </summary>
public interface IErrorBarValue // : DocumentFormat.OpenXml.Drawing.Charts.DoubleType
{
  /// <summary>
  /// Floating Point Value
  /// </summary>
  public double? Val { get ; set; }
  
}
