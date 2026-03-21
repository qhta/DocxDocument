namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single instance of a custom property for a smart tag.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperty?view=word-pia"/>
public partial interface CustomProperty : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperty.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.customproperty.value?view=word-pia"/>
  public string Value { get; set; }
}
