namespace DocumentModel.Math;

/// <summary>
/// Shape (Delimiters).
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public ShapeDelimiterValues? Val { get ; set; }
  
}
