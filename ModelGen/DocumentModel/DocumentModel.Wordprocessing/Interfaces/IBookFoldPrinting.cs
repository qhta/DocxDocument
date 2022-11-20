namespace DocumentModel.Wordprocessing;

/// <summary>
/// Book Fold Printing.
/// </summary>
public interface IBookFoldPrinting // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
