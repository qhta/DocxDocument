namespace DocumentModel.Wordprocessing;

/// <summary>
/// Inline Embedded Object.
/// </summary>
public interface EmbeddedObject
{
  /// <summary>
  /// dxaOrig
  /// </summary>
  public String? DxaOriginal { get ; set; }
  
  /// <summary>
  /// dyaOrig
  /// </summary>
  public String? DyaOriginal { get ; set; }
  
  /// <summary>
  /// anchorId, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.HexBinary? AnchorId { get ; set; }
  
  public DocumentModel.Vml.Group? Group { get ; set; }
  
  public DocumentModel.Vml.ImageFile? ImageFile { get ; set; }
  
  public DocumentModel.Vml.Line? Line { get ; set; }
  
  public DocumentModel.Vml.Oval? Oval { get ; set; }
  
  public DocumentModel.Vml.PolyLine? PolyLine { get ; set; }
  
  public DocumentModel.Vml.Rectangle? Rectangle { get ; set; }
  
  public DocumentModel.Vml.RoundRectangle? RoundRectangle { get ; set; }
  
  public DocumentModel.Vml.Shape? Shape { get ; set; }
  
  public DocumentModel.Vml.Shapetype? Shapetype { get ; set; }
  
  public DocumentModel.Vml.Arc? Arc { get ; set; }
  
  public DocumentModel.Vml.Curve? Curve { get ; set; }
  
  public DocumentModel.Vml.OleObject? OleObject { get ; set; }
  
  public DocumentModel.Wordprocessing.Drawing? Drawing { get ; set; }
  
  public DocumentModel.Wordprocessing.Control? Control { get ; set; }
  
  public DocumentModel.Wordprocessing.ObjectEmbed? ObjectEmbed { get ; set; }
  
  public DocumentModel.Wordprocessing.ObjectLink? ObjectLink { get ; set; }
  
}
