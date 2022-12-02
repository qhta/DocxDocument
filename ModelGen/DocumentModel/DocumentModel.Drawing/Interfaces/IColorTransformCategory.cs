namespace DocumentModel.Drawing;

/// <summary>
/// Color Transform Category.
/// </summary>
public interface IColorTransformCategory // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Category Type
  /// </summary>
  public String? Type { get ; set; }
  
  /// <summary>
  /// Priority
  /// </summary>
  public UInt32? Priority { get ; set; }
  
}
