namespace DocumentModel.InkML;

/// <summary>
/// Defines the BrushProperty Class.
/// </summary>
public interface IBrushProperty // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public System.String? Name { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public System.String? Value { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public System.String? Units { get ; set; }
  
}
