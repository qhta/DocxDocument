namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single text column.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumn?view=word-pia"/>
public interface TextColumn : InteropObject
{
  /// <summary>
  /// The width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumn.width?view=word-pia"/>
  public float Width { get; set; }
  /// <summary>
  /// The space after.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.textcolumn.spaceafter?view=word-pia"/>
  public float SpaceAfter { get; set; }

}
