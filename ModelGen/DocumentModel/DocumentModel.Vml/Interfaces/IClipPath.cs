namespace DocumentModel.Vml;

/// <summary>
/// Shape Clipping Path.
/// </summary>
public interface IClipPath // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Path Definition
  /// </summary>
  public System.String? Value { get ; set; }
  
}
