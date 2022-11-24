namespace DocumentModel.Presentation;

/// <summary>
/// Video.
/// </summary>
public interface IVideo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Full Screen
  /// </summary>
  public Boolean? FullScreen { get ; set; }
  
  /// <summary>
  /// Common Media Node Properties.
  /// </summary>
  public ICommonMediaNode? CommonMediaNode { get ; set; }
  
}
