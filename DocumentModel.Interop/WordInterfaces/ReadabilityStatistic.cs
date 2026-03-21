namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents one of the readability statistics for a document or range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.readabilitystatistic?view=word-pia"/>
public interface ReadabilityStatistic : InteropObject
{
  /// <summary>
  /// Returns the name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.readabilitystatistic.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Returns the value.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.readabilitystatistic.value?view=word-pia"/>
  public float Value { get; }

}
