namespace DocumentModel.Presentation;

/// <summary>
/// Defines the StripsTransition Class.
/// </summary>
public interface IStripsTransition // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionCornerDirectionValues? Direction { get ; set; }
  
}
