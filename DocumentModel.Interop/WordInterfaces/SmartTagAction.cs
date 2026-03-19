namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single action for a smart tag.
/// </summary>
public partial interface SmartTagAction : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  public string Name { get; }

  /// <summary>
  /// The type.
  /// </summary>
  public WdSmartTagControlType Type { get; }

  /// <summary>
  /// The present in pane.
  /// </summary>
  public bool PresentInPane { get; }

  /// <summary>
  /// The expand help.
  /// </summary>
  public bool ExpandHelp { get; set; }

  /// <summary>
  /// The checkbox state.
  /// </summary>
  public bool CheckboxState { get; set; }

  /// <summary>
  /// The textbox text.
  /// </summary>
  public string TextboxText { get; set; }

  /// <summary>
  /// The list selection.
  /// </summary>
  public int ListSelection { get; set; }

  /// <summary>
  /// The radio group selection.
  /// </summary>
  public int RadioGroupSelection { get; set; }

  /// <summary>
  /// The expand document fragment.
  /// </summary>
  public bool ExpandDocumentFragment { get; set; }

  /// <summary>
  /// The active xcontrol.
  /// </summary>
  public object ActiveXControl { get; }
}
