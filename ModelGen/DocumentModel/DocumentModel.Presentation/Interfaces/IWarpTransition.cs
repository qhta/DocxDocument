namespace DocumentModel.Presentation;

/// <summary>
/// Defines the WarpTransition Class.
/// </summary>
public interface IWarpTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public DocumentModel.Presentation.TransitionInOutDirectionKind? Direction { get ; set; }
  
}
