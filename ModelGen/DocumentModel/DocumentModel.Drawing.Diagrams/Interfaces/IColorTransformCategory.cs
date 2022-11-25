namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Color Transform Category.
/// </summary>
public interface IColorTransformCategory // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Category Type
  /// </summary>
  public System.String? Type { get ; set; }
  
  /// <summary>
  /// Priority
  /// </summary>
  public System.UInt32? Priority { get ; set; }
  
}
