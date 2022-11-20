namespace DocumentModel.Wordprocessing;

/// <summary>
/// Absolute Position Tab Character.
/// </summary>
public interface IPositionalTab // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// Positional Tab Stop Alignment
  /// </summary>
  public AbsolutePositionTabAlignmentValues? Alignment { get ; set; }
  
  /// <summary>
  /// Positional Tab Base
  /// </summary>
  public AbsolutePositionTabPositioningBaseValues? RelativeTo { get ; set; }
  
  /// <summary>
  /// Tab Leader Character
  /// </summary>
  public AbsolutePositionTabLeaderCharValues? Leader { get ; set; }
  
}
