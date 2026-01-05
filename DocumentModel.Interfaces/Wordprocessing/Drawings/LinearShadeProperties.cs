namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the LinearShadeProperties Class.
/// </summary>
public interface LinearShadeProperties:
{
  /// <summary>
  ///   ang
  /// </summary>
  public Int32? Angle { get; set; }
  /// <summary>
  ///   scaled
  /// </summary>
  public OnOffKind? Scaled { get; set; }
}