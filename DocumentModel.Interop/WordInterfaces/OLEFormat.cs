namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the OLE characteristics (other than linking) for an OLE object, ActiveX control, or field.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat?view=word-pia"/>
public partial interface OLEFormat : InteropObject
{
  /// <summary>
  /// The class type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.classtype?view=word-pia"/>
  public string ClassType { get; set; }

  /// <summary>
  /// The display as icon.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.displayasicon?view=word-pia"/>
  public bool DisplayAsIcon { get; set; }

  /// <summary>
  /// The icon name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconname?view=word-pia"/>
  public string IconName { get; set; }

  /// <summary>
  /// The icon path.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconpath?view=word-pia"/>
  public string IconPath { get; }

  /// <summary>
  /// The icon index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconindex?view=word-pia"/>
  public int IconIndex { get; set; }

  /// <summary>
  /// The icon label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconlabel?view=word-pia"/>
  public string IconLabel { get; set; }

  /// <summary>
  /// The label.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.label?view=word-pia"/>
  public string Label { get; }

  /// <summary>
  /// The object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.object?view=word-pia"/>
  public object Object { get; }

  /// <summary>
  /// The prog id.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.progid?view=word-pia"/>
  public string ProgID { get; }

  /// <summary>
  /// The preserve formatting on update.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.preserveformattingonupdate?view=word-pia"/>
  public bool PreserveFormattingOnUpdate { get; set; }
}
