namespace DocumentModel.Presentation;

/// <summary>
/// Defines the StripsTransition Class.
/// </summary>
public interface IStripsTransition // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Direction
  /// </summary>
  public TransitionCornerDirectionValues? Direction { get ; set; }
  
}
