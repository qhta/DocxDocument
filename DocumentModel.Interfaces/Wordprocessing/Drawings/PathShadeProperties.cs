namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the PathShadeProperties Class.
/// </summary>
public interface PathShadeProperties: IModelElement
{
  /// <summary>
  ///   path
  /// </summary>
  public PathShadeKind? Path { get; set; }
  /// <summary>
  ///   FillToRectangle.
  /// </summary>
  public FillToRectangle? FillToRectangle { get; set; }
}