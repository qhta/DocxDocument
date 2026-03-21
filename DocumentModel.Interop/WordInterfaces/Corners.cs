namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the corners of a 3-D chart.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.corners?view=word-pia"/>
public partial interface Corners : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.corners.name?view=word-pia"/>
  public string Name { get; }
}
