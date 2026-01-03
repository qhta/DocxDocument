namespace DocumentModel.Wordprocessing.Vml;

/// <summary>
///   Defines the BorderType Class.
/// </summary>
public interface BorderType: IModelElement
{
  /// <summary>
  ///   Border Style
  /// </summary>
  public BorderKind? Type { get; set; }
  /// <summary>
  ///   Border Width
  /// </summary>
  public Int64? Width { get; set; }
  /// <summary>
  ///   Border shadow
  /// </summary>
  public bool? Shadow { get; set; }
}