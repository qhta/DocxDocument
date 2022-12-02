namespace DocumentModel.Spreadsheet.Drawing;

/// <summary>
/// Absolute Anchor Shape Size.
/// </summary>
public interface IAbsoluteAnchor // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Position.
  /// </summary>
  public IPosition? Position { get ; set; }
  
  /// <summary>
  /// Shape Extent.
  /// </summary>
  public IExtent? Extent { get ; set; }
  
  public IShape? Shape { get ; set; }
  
  public IGroupShape? GroupShape { get ; set; }
  
  public IGraphicFrame? GraphicFrame { get ; set; }
  
  public IConnectionShape? ConnectionShape { get ; set; }
  
  public IPicture? Picture { get ; set; }
  
  public IClientData? ClientData { get ; set; }
  
}
