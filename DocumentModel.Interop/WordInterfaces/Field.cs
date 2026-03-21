namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a field. The Field object is a member of the Fields collection. The Fields collection represents the fields in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field?view=word-pia"/>
public partial interface Field : InteropObject
{
  /// <summary>
  /// The code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.code?view=word-pia"/>
  public Range Code { get; set; }

  /// <summary>
  /// The type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.type?view=word-pia"/>
  public WdFieldType Type { get; }

  /// <summary>
  /// The locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// The kind.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.kind?view=word-pia"/>
  public WdFieldKind Kind { get; }

  /// <summary>
  /// The result.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.result?view=word-pia"/>
  public Range Result { get; set; }

  /// <summary>
  /// The data.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.data?view=word-pia"/>
  public string Data { get; set; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.next?view=word-pia"/>
  public Field Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.previous?view=word-pia"/>
  public Field Previous { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The show codes.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.showcodes?view=word-pia"/>
  public bool ShowCodes { get; set; }

  /// <summary>
  /// The link format.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.linkformat?view=word-pia"/>
  public LinkFormat LinkFormat { get; }

  /// <summary>
  /// The oleformat.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.oleformat?view=word-pia"/>
  public OLEFormat OLEFormat { get; }

  /// <summary>
  /// The inline shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.inlineshape?view=word-pia"/>
  public InlineShape InlineShape { get; }
}
