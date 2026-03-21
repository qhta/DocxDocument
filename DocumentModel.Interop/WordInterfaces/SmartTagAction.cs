namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single action for a smart tag.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction?view=word-pia"/>
public partial interface SmartTagAction : InteropObject
{
  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.type?view=word-pia"/>
  public WdSmartTagControlType Type { get; }

  /// <summary>
  /// Returns whether present in pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.presentinpane?view=word-pia"/>
  public bool PresentInPane { get; }

  /// <summary>
  /// Returns or sets whether expand help.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.expandhelp?view=word-pia"/>
  public bool ExpandHelp { get; set; }

  /// <summary>
  /// Returns or sets whether checkbox state.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.checkboxstate?view=word-pia"/>
  public bool CheckboxState { get; set; }

  /// <summary>
  /// Returns or sets the textbox text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.textboxtext?view=word-pia"/>
  public string TextboxText { get; set; }

  /// <summary>
  /// Returns or sets the list selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.listselection?view=word-pia"/>
  public int ListSelection { get; set; }

  /// <summary>
  /// Returns or sets the radio group selection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.radiogroupselection?view=word-pia"/>
  public int RadioGroupSelection { get; set; }

  /// <summary>
  /// Returns or sets whether expand document fragment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.expanddocumentfragment?view=word-pia"/>
  public bool ExpandDocumentFragment { get; set; }

  /// <summary>
  /// Returns the active x control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.activexcontrol?view=word-pia"/>
  public object ActiveXControl { get; }
}
