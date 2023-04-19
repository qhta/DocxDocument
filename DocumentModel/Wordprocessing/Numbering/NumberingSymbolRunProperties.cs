namespace DocumentModel.Wordprocessing;

/// <summary>
///   Numbering Symbol Run Properties.
/// </summary>
public class NumberingSymbolRunProperties: BaseRunProperties
{
  /// <summary>
  ///   Specifies whether the contents of this run shall be treated as complex script text regardless of their Unicode character values when determining the formatting for this run. 
  /// </summary>
  public bool? ComplexScript { get; set; }

  /// <summary>
  ///   Specifies whether the contents of this run shall have right-to-left characteristics.
  /// </summary>
  public bool? RightToLeftText { get; set; }
}