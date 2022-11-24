namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Category.
/// </summary>
public interface IStyleDisplayCategory // : DocumentModel.ITypedOpenXmlLeafElement
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
