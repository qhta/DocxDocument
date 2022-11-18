namespace DocumentModel.Wordprocessing;

/// <summary>
/// Do Not Snap to Document Grid in Table Cells with Objects.
/// </summary>
public interface IDoNotSnapToGridInCell // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
