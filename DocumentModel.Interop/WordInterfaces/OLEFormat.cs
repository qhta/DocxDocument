namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the OLE characteristics (other than linking) for an OLE object, ActiveX control, or field.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat?view=word-pia"/>
public partial interface OLEFormat : InteropObject
{
  /// <summary>
  /// The class type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.classtype?view=word-pia"/>
  public string ClassType { get; set; }

  /// <summary>
  /// The display as icon.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.displayasicon?view=word-pia"/>
  public bool DisplayAsIcon { get; set; }

  /// <summary>
  /// The icon name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconname?view=word-pia"/>
  public string IconName { get; set; }

  /// <summary>
  /// The icon path.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconpath?view=word-pia"/>
  public string IconPath { get; }

  /// <summary>
  /// The icon index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconindex?view=word-pia"/>
  public int IconIndex { get; set; }

  /// <summary>
  /// The icon label.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconlabel?view=word-pia"/>
  public string IconLabel { get; set; }

  /// <summary>
  /// The label.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.label?view=word-pia"/>
  public string Label { get; }

  /// <summary>
  /// The object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.object?view=word-pia"/>
  public object Object { get; }

  /// <summary>
  /// The prog id.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.progid?view=word-pia"/>
  public string ProgID { get; }

  /// <summary>
  /// The preserve formatting on update.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.preserveformattingonupdate?view=word-pia"/>
  public bool PreserveFormattingOnUpdate { get; set; }
}
