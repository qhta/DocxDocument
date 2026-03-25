namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip?view=word-pia"/>
public partial interface RoutingSlip: InteropObject
{
  /// <summary>
  /// Returns the recipients of the routing slip at the specified index.
  /// </summary>
  /// <param name="Index">Specifies the index.</param>
  /// <returns>The resulting value.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.routingslip.recipients?view=word-pia"/>
  public object Recipients(object Index);
}
