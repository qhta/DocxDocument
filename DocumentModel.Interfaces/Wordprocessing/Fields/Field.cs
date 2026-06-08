namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a field. The Field object is a member of the Fields collection. The Fields collection represents the fields in a selection, range, or document.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field?view=word-pia"/>
public partial interface Field : IModelObject
{
  /// <summary>
  /// Gets or sets the field code.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.code?view=word-pia"/>
  public IRange Code { get; set; }

  /// <summary>
  /// Gets the field type.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.type?view=word-pia"/>
  public FieldType Type { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the field is locked.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.locked?view=word-pia"/>
  public bool Locked { get; set; }

  /// <summary>
  /// Gets the field kind.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.kind?view=word-pia"/>
  public FieldKind Kind { get; }

  /// <summary>
  /// Gets or sets the result displayed for the field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.result?view=word-pia"/>
  public IRange Result { get; set; }

  /// <summary>
  /// Gets or sets data associated with the field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.data?view=word-pia"/>
  public string Data { get; set; }

  /// <summary>
  /// Gets the next field in the `Fields` collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.next?view=word-pia"/>
  public Field Next { get; }

  /// <summary>
  /// Gets the previous field in the `Fields` collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.previous?view=word-pia"/>
  public Field Previous { get; }

  /// <summary>
  /// Gets the index number of the field in the `Fields` collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets or sets a value indicating whether field codes are displayed instead of field results.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.showcodes?view=word-pia"/>
  public bool ShowCodes { get; set; }

  /// <summary>
  /// Gets the inline shape associated with the field.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.field.inlineshape?view=word-pia"/>
  public DMD.InlineShape InlineShape { get; }
}
