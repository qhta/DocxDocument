namespace DocumentModel.Math;

/// <summary>
/// Break.
/// </summary>
public interface IBreak // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public int? AlignAt { get ; set; }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public int? Val { get ; set; }
  
}
