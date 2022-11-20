namespace DocumentModel.Wordprocessing;

/// <summary>
/// Add Document Grid Line Pitch To Lines in Table Cells.
/// </summary>
public interface IAdjustLineHeightInTable // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
