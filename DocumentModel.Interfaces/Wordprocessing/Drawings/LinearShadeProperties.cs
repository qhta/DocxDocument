namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the LinearShadeProperties Class.
/// </summary>
public class LinearShadeProperties: ModelElement
{
  /// <summary>
  ///   ang, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Angle { get; set; }
  /// <summary>
  ///   scaled, this property is only available in Office 2010 and later.
  /// </summary>
  public OnOffKind? Scaled { get; set; }
}