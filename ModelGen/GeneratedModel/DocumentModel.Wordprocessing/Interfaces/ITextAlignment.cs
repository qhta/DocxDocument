namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TextAlignment Class.
/// </summary>
public interface ITextAlignment // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Vertical Character Alignment Position
  /// </summary>
  public VerticalTextAlignment? Val { get ; set; }
  
}
