namespace DocumentModel.Math;

/// <summary>
/// Shape (Delimiters).
/// </summary>
public interface IShape // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Value
  /// </summary>
  public ShapeDelimiterValues? Val { get ; set; }
  
}
