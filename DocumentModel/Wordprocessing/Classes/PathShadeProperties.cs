namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PathShadeProperties Class.
/// </summary>
public partial class PathShadeProperties
{
  /// <summary>
  /// path, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Wordprocessing.PathShadeKind? Path { get; set; }
  
  /// <summary>
  /// FillToRectangle.
  /// </summary>
  public DocumentModel.Wordprocessing.FillToRectangle? FillToRectangle { get; set; }
  
}
