namespace DocumentModel.Wordprocessing;

/// <summary>
/// Only Expand/Condense Text By Whole Points.
/// </summary>
public interface ISpacingInWholePoints // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
