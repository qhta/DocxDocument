namespace DocumentModel.Wordprocessing;

/// <summary>
/// Frameset Splitter Properties.
/// </summary>
public interface IFramesetSplitbar // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Frameset Splitter Width.
  /// </summary>
  public System.String? Width { get ; set; }
  
  /// <summary>
  /// Frameset Splitter Color.
  /// </summary>
  public DocumentModel.Wordprocessing.IColor? Color { get ; set; }
  
  /// <summary>
  /// Do Not Display Frameset Splitters.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? NoBorder { get ; set; }
  
  /// <summary>
  /// Frameset Splitter Border Style.
  /// </summary>
  public DocumentModel.Wordprocessing.OnOffOnlyKind? FlatBorders { get ; set; }
  
}
