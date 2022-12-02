namespace DocumentModel.Presentation;

/// <summary>
/// Defines the WarpTransition Class.
/// </summary>
public interface IWarpTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirectionKind? Direction { get ; set; }
  
}
