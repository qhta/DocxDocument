namespace DocumentModel.Wordprocessing;

/// <summary>
/// Justification.
/// </summary>
public interface ILevelJustification // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Alignment Type
  /// </summary>
  public LevelJustificationValues? Val { get ; set; }
  
}
