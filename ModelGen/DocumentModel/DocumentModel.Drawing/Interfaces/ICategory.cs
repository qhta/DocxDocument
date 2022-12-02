namespace DocumentModel.Drawing;

/// <summary>
/// Category.
/// </summary>
public interface ICategory // : DocumentModel.ITypedOpenXmlLeafElement
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
