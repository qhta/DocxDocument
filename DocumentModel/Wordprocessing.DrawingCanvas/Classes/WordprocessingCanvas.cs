using DocumentModel.Wordprocessing.DrawingGroup;
using DocumentModel.Wordprocessing.DrawingShape;

namespace DocumentModel.Wordprocessing.DrawingCanvas;

/// <summary>
///   Defines the WordprocessingCanvas Class.
/// </summary>
public record WordprocessingCanvas
{
  /// <summary>
  ///   BackgroundFormatting.
  /// </summary>
  public BackgroundFormatting? BackgroundFormatting { get; set; }

  /// <summary>
  ///   WholeFormatting.
  /// </summary>
  public WholeFormatting? WholeFormatting { get; set; }

  public WordprocessingShape? WordprocessingShape { get; set; }

  public DocumentModel.Drawings.Pictures.Picture? Picture { get; set; }

  public WordprocessingGroup? WordprocessingGroup { get; set; }

  public GraphicFrameType? GraphicFrameType { get; set; }

  public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}