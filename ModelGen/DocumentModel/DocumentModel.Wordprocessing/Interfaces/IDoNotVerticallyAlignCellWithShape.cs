namespace DocumentModel.Wordprocessing;

/// <summary>
/// Don't Vertically Align Cells Containing Floating Objects.
/// </summary>
public interface IDoNotVerticallyAlignCellWithShape // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
