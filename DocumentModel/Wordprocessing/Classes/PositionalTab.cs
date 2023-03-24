namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
/// Represents an absolute position tab character in text run. 
/// An absolute position tab is a character which is used to advance the position on the current line of text, using the following logic:
/// <list type="bullet">
/// <item>
/// Regardless of any number of custom tab stops defined using the tabs element, 
/// the absolute position tab character shall advance to the position specified by its alignment and relativeTo attributes. 
/// The resulting end position of the tab character shall not be affected by the addition of any custom tab stops 
/// or changes to the value of the defaultTabStop element.
/// </item>
/// <item>
/// If the alignment location specified by the positional tab cannot be found on the current line, 
/// because the starting location is past that point, 
/// then the tab character shall advance to that location on the next available line in the document.
/// </item>
/// </list>
/// </summary>
public class PositionalTab: ModelElement, IRunElement
{
  /// <summary>
  ///   Positional Tab Stop Alignment
  /// </summary>
  public AbsolutePositionTabAlignmentKind? Alignment { get; set; }

  /// <summary>
  ///   Positional Tab Base
  /// </summary>
  public AbsolutePositionTabPositioningBaseKind? RelativeTo { get; set; }

  /// <summary>
  ///   Tab Leader Character
  /// </summary>
  public AbsolutePositionTabLeaderCharKind? Leader { get; set; }
}