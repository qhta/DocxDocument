namespace DocumentModel.Vml.Office;

/// <summary>
/// Shape Clipping Path.
/// </summary>
public interface IClipPath // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Path Definition
  /// </summary>
  public String? Value { get ; set; }
  
}
