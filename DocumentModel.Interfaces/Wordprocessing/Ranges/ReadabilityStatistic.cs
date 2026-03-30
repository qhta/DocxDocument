namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents one of the readability statistics for a document or range.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.readabilitystatistic?view=word-pia"/>
public interface IReadabilityStatistic : IModelObject
{
  /// <summary>
  /// Returns or sets the name of the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.readabilitystatistic.name?view=word-pia"/>
  public string Name { get; }
  /// <summary>
  /// Returns the value of the grammar statistic.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.readabilitystatistic.value?view=word-pia"/>
  public float Value { get; }

}
