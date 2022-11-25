namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Category.
/// </summary>
public interface ICategory // : DocumentModel.ITypedOpenXmlLeafElement
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
