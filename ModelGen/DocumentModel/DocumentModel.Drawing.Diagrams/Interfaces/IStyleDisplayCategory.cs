namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Category.
/// </summary>
public interface IStyleDisplayCategory // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Category Type
  /// </summary>
  public string? Type { get ; set; }
  
  /// <summary>
  /// Priority
  /// </summary>
  public uint? Priority { get ; set; }
  
}
