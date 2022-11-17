namespace DocumentModel.Wordprocessing;

public interface IFrameProperties // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public DropCapLocation? DropCap { get ; set; }
  
  public int? Lines { get ; set; }
  
  public string? Width { get ; set; }
  
  public uint? Height { get ; set; }
  
  public string? VerticalSpace { get ; set; }
  
  public string? HorizontalSpace { get ; set; }
  
  public DocumentModel.Wordprocessing.TextWrapping? Wrap { get ; set; }
  
  public DocumentModel.Wordprocessing.HorizontalAnchor? HorizontalPosition { get ; set; }
  
  public DocumentModel.Wordprocessing.VerticalAnchor? VerticalPosition { get ; set; }
  
  public string? X { get ; set; }
  
  public DocumentModel.Wordprocessing.HorizontalAlignment? XAlign { get ; set; }
  
  public string? Y { get ; set; }
  
  public DocumentModel.Wordprocessing.VerticalAlignment? YAlign { get ; set; }
  
  public HeightRule? HeightType { get ; set; }
  
  public bool? AnchorLock { get ; set; }
  
}
