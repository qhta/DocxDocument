namespace DocumentModel.Math;

/// <summary>
/// Break.
/// </summary>
public interface IBreak // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public System.Int32? AlignAt { get ; set; }
  
  /// <summary>
  /// Index of Operator to Align To
  /// </summary>
  public System.Int32? Val { get ; set; }
  
}
