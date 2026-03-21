namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single AutoText entry.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry?view=word-pia"/>
public partial interface AutoTextEntry : InteropObject
{
  /// <summary>
  /// The index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.name?view=word-pia"/>
  public string Name { get; set; }

  /// <summary>
  /// The style name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.stylename?view=word-pia"/>
  public string StyleName { get; }

  /// <summary>
  /// The value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.autotextentry.value?view=word-pia"/>
  public string Value { get; set; }
}
