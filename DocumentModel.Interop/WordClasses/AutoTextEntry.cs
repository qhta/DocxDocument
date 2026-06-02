namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single AutoText entry.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry?view=word-pia"/>
public partial class AutoTextEntry : InteropObject
{
  /// <summary>
  /// Gets the index number of the AutoText entry in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.index?view=word-pia"/>
  public int Index { get; set; }

  /// <summary>
  /// Gets or sets the name of the AutoText entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.name?view=word-pia"/>
  public string? Name { get; set; }

  /// <summary>
  /// Gets the style name associated with the AutoText entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.stylename?view=word-pia"/>
  public string? StyleName { get; set; }

  /// <summary>
  /// Gets or sets the text value of the AutoText entry.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.value?view=word-pia"/>
  public string? Value { get; set; }


  #region methods

/// <summary>
  /// Deletes the specified object.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.delete?view=word-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}
