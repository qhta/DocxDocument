namespace DocumentModel.InkML;

/// <summary>
/// Defines the BrushProperty Class.
/// </summary>
public interface IBrushProperty // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// value
  /// </summary>
  public String? Value { get ; set; }
  
  /// <summary>
  /// units
  /// </summary>
  public String? Units { get ; set; }
  
}
