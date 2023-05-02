namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PathShadeProperties Class.
/// </summary>
public class PathShadeProperties: ModelElement
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