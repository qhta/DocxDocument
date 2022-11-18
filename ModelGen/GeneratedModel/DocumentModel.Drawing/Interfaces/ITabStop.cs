namespace DocumentModel.Drawing;

/// <summary>
/// Tab Stop.
/// </summary>
public interface ITabStop // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Tab Position
  /// </summary>
  public int? Position { get ; set; }
  
  /// <summary>
  /// Tab Alignment
  /// </summary>
  public TextTabAlignment? Alignment { get ; set; }
  
}
