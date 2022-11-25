namespace DocumentModel.Presentation;

/// <summary>
/// Video.
/// </summary>
public interface IVideo // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Full Screen
  /// </summary>
  public System.Boolean? FullScreen { get ; set; }
  
  /// <summary>
  /// Common Media Node Properties.
  /// </summary>
  public DocumentModel.Presentation.ICommonMediaNode? CommonMediaNode { get ; set; }
  
}
