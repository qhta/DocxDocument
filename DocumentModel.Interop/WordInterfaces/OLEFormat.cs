namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the OLE characteristics (other than linking) for an OLE object, ActiveX control, or field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat?view=word-pia"/>
public partial interface OLEFormat : InteropObject
{
  /// <summary>
  /// Returns or sets the class type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.classtype?view=word-pia"/>
  public string ClassType { get; set; }

  /// <summary>
  /// Returns or sets whether display as icon.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.displayasicon?view=word-pia"/>
  public bool DisplayAsIcon { get; set; }

  /// <summary>
  /// Returns or sets the icon name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconname?view=word-pia"/>
  public string IconName { get; set; }

  /// <summary>
  /// Returns the icon path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconpath?view=word-pia"/>
  public string IconPath { get; }

  /// <summary>
  /// Returns or sets the icon index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconindex?view=word-pia"/>
  public int IconIndex { get; set; }

  /// <summary>
  /// Returns or sets the icon label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconlabel?view=word-pia"/>
  public string IconLabel { get; set; }

  /// <summary>
  /// Returns the label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.label?view=word-pia"/>
  public string Label { get; }

  /// <summary>
  /// Returns the object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.object?view=word-pia"/>
  public object Object { get; }

  /// <summary>
  /// Returns the prog i d.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.progid?view=word-pia"/>
  public string ProgID { get; }

  /// <summary>
  /// Returns or sets whether preserve formatting on update.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.preserveformattingonupdate?view=word-pia"/>
  public bool PreserveFormattingOnUpdate { get; set; }
}
