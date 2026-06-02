namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a field. The Field object is a member of the Fields collection. The Fields collection represents the fields in a selection, range, or document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field?view=word-pia"/>
public partial interface IField : IInteropObject
{
  /// <summary>
  /// Gets or sets the field code.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.code?view=word-pia"/>
  public Range Code { get; set; }

  /// <summary>
  /// Gets the field type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.type?view=word-pia"/>
  public FieldType Type { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the field is locked.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// Gets the field kind.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.kind?view=word-pia"/>
  public FieldKind Kind { get; }

  /// <summary>
  /// Gets or sets the result displayed for the field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.result?view=word-pia"/>
  public Range Result { get; set; }

  /// <summary>
  /// Gets or sets data associated with the field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.data?view=word-pia"/>
  public string Data { get; set; }

  /// <summary>
  /// Gets the next field in the `Fields` collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.next?view=word-pia"/>
  public Field Next { get; }

  /// <summary>
  /// Gets the previous field in the `Fields` collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.previous?view=word-pia"/>
  public Field Previous { get; }

  /// <summary>
  /// Gets the index number of the field in the `Fields` collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets or sets a value indicating whether field codes are displayed instead of field results.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.showcodes?view=word-pia"/>
  public bool ShowCodes { get; set; }

  /// <summary>
  /// Gets the link formatting for a linked field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.linkformat?view=word-pia"/>
  public LinkFormat LinkFormat { get; }

  /// <summary>
  /// Gets the OLE formatting for an OLE field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.oleformat?view=word-pia"/>
  public OLEFormat OLEFormat { get; }

  /// <summary>
  /// Gets the inline shape associated with the field.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.inlineshape?view=word-pia"/>
  public InlineShape InlineShape { get; }
}
