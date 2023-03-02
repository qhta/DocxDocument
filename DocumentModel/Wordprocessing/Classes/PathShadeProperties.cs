namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PathShadeProperties Class.
/// </summary>
public record PathShadeProperties
{
  /// <summary>
  ///   path, this property is only available in Office 2010 and later.
  /// </summary>
  public PathShadeKind? Path { get; set; }

  /// <summary>
  ///   FillToRectangle.
  /// </summary>
  public FillToRectangle? FillToRectangle { get; set; }
}