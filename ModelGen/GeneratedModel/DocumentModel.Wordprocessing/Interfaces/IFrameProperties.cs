namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FrameProperties Class.
/// </summary>
public interface IFrameProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Drop Cap Frame
  /// </summary>
  public DropCapLocation? DropCap { get ; set; }
  
  /// <summary>
  /// Drop Cap Vertical Height in Lines
  /// </summary>
  public int? Lines { get ; set; }
  
  /// <summary>
  /// Frame Width
  /// </summary>
  public string? Width { get ; set; }
  
  /// <summary>
  /// Frame Height
  /// </summary>
  public uint? Height { get ; set; }
  
  /// <summary>
  /// Vertical Frame Padding
  /// </summary>
  public string? VerticalSpace { get ; set; }
  
  /// <summary>
  /// Horizontal Frame Padding
  /// </summary>
  public string? HorizontalSpace { get ; set; }
  
  /// <summary>
  /// Text Wrapping Around Frame
  /// </summary>
  public DocumentModel.Wordprocessing.TextWrapping? Wrap { get ; set; }
  
  /// <summary>
  /// Frame Horizontal Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAnchor? HorizontalPosition { get ; set; }
  
  /// <summary>
  /// Frame Vertical Positioning Base
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAnchor? VerticalPosition { get ; set; }
  
  /// <summary>
  /// Absolute Horizontal Position
  /// </summary>
  public string? X { get ; set; }
  
  /// <summary>
  /// Relative Horizontal Position
  /// </summary>
  public DocumentModel.Wordprocessing.HorizontalAlignment? XAlign { get ; set; }
  
  /// <summary>
  /// Absolute Vertical Position
  /// </summary>
  public string? Y { get ; set; }
  
  /// <summary>
  /// Relative Vertical Position
  /// </summary>
  public DocumentModel.Wordprocessing.VerticalAlignment? YAlign { get ; set; }
  
  /// <summary>
  /// Frame Height Type
  /// </summary>
  public HeightRule? HeightType { get ; set; }
  
  /// <summary>
  /// Lock Frame Anchor to Paragraph
  /// </summary>
  public bool? AnchorLock { get ; set; }
  
}
