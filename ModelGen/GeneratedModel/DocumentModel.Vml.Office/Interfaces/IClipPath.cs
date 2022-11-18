namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Clipping Path.
/// </summary>
public interface IClipPath // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Path Definition
  /// </summary>
  public string? Value { get ; set; }
  
}
