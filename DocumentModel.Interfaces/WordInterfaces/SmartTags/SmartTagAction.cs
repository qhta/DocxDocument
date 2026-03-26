namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single action for a smart tag.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction?view=word-pia"/>
public partial interface SmartTagAction : InteropObject
{
  /// <summary>
  /// Returns the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Returns a SmartTagControlType that represents the type of Smart Document control displayed in the Document
  /// Actions task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.type?view=word-pia"/>
  public SmartTagControlType Type { get; }

  /// <summary>
  /// Returns a Boolean that represents whether a smart document control is currently displayed in the Document
  /// Actions task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.presentinpane?view=word-pia"/>
  public bool PresentInPane { get; }

  /// <summary>
  /// Returns or sets a Boolean that represents whether the specified smart document Help text control is expanded
  /// or collapsed in the Document Actions task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.expandhelp?view=word-pia"/>
  public bool ExpandHelp { get; set; }

  /// <summary>
  /// Returns or sets a Boolean that indicates whether a check box in a smart document is selected.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.checkboxstate?view=word-pia"/>
  public bool CheckboxState { get; set; }

  /// <summary>
  /// Returns or sets a String that represents the text in a smart document textbox control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.textboxtext?view=word-pia"/>
  public string TextboxText { get; set; }

  /// <summary>
  /// Returns or sets an Integer that represents the index number of the selected item in a smart document list box
  /// control.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.listselection?view=word-pia"/>
  public int ListSelection { get; set; }

  /// <summary>
  /// Returns or sets an Integer that represents the index number of the selected item in a group of radio button
  /// controls in a smart document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.radiogroupselection?view=word-pia"/>
  public int RadioGroupSelection { get; set; }

  /// <summary>
  /// Returns a 32-bit integer that indicates the application in which the specified object was created.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.expanddocumentfragment?view=word-pia"/>
  public bool ExpandDocumentFragment { get; set; }

  /// <summary>
  /// Returns an Object that represents an ActiveX control displayed in the Document Actions task pane.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.smarttagaction.activexcontrol?view=word-pia"/>
  public object ActiveXControl { get; }
}
