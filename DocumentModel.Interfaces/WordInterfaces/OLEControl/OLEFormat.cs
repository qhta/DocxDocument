namespace DocumentModel.Wordprocessing;

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
  /// Returns or sets whether the OLE object is displayed as an icon.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.displayasicon?view=word-pia"/>
  public bool DisplayAsIcon { get; set; }

  /// <summary>
  /// Returns or sets the icon file name for the OLE object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconname?view=word-pia"/>
  public string IconName { get; set; }

  /// <summary>
  /// Returns the path of the icon file for the OLE object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconpath?view=word-pia"/>
  public string IconPath { get; }

  /// <summary>
  /// Returns or sets the icon index within the icon file.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconindex?view=word-pia"/>
  public int IconIndex { get; set; }

  /// <summary>
  /// Returns or sets the caption displayed under the OLE object icon.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.iconlabel?view=word-pia"/>
  public string IconLabel { get; set; }

  /// <summary>
  /// Returns the source label for the OLE object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.label?view=word-pia"/>
  public string Label { get; }

  /// <summary>
  /// Returns the OLE automation object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.object?view=word-pia"/>
  public object Object { get; }

  /// <summary>
  /// Returns the ProgID of the OLE object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.progid?view=word-pia"/>
  public string ProgID { get; }

  /// <summary>
  /// Returns or sets whether formatting is preserved when the linked OLE object is updated.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.oleformat.preserveformattingonupdate?view=word-pia"/>
  public bool PreserveFormattingOnUpdate { get; set; }
}
