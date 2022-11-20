namespace DocumentModel.Wordprocessing;

/// <summary>
/// Select Field When First or Last Character Is Selected.
/// </summary>
public interface ISelectFieldWithFirstOrLastChar // : DocumentFormat.OpenXml.Wordprocessing.OnOffType
{
  /// <summary>
  /// On/Off Value
  /// </summary>
  public bool? Val { get ; set; }
  
}
