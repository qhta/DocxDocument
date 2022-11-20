namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the WarpTransition Class.
/// </summary>
public interface IWarpTransition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionInOutDirectionValues? Direction { get ; set; }
  
}
