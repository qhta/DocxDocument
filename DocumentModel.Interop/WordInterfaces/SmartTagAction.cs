namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single action for a smart tag.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction?view=word-pia"/>
public partial interface SmartTagAction : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.type?view=word-pia"/>
  public WdSmartTagControlType Type { get; }

  /// <summary>
  /// The present in pane.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.presentinpane?view=word-pia"/>
  public bool PresentInPane { get; }

  /// <summary>
  /// The expand help.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.expandhelp?view=word-pia"/>
  public bool ExpandHelp { get; set; }

  /// <summary>
  /// The checkbox state.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.checkboxstate?view=word-pia"/>
  public bool CheckboxState { get; set; }

  /// <summary>
  /// The textbox text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.textboxtext?view=word-pia"/>
  public string TextboxText { get; set; }

  /// <summary>
  /// The list selection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.listselection?view=word-pia"/>
  public int ListSelection { get; set; }

  /// <summary>
  /// The radio group selection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.radiogroupselection?view=word-pia"/>
  public int RadioGroupSelection { get; set; }

  /// <summary>
  /// The expand document fragment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.expanddocumentfragment?view=word-pia"/>
  public bool ExpandDocumentFragment { get; set; }

  /// <summary>
  /// The active xcontrol.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.activexcontrol?view=word-pia"/>
  public object ActiveXControl { get; }
}
