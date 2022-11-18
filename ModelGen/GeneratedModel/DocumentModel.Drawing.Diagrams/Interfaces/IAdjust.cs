namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Shape Adjust.
/// </summary>
public interface IAdjust // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Adjust Handle Index
  /// </summary>
  public uint? Index { get ; set; }
  
  /// <summary>
  /// Value
  /// </summary>
  public double? Val { get ; set; }
  
}
