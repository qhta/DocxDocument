namespace DocumentModel.Interop;

public partial interface RoutingSlip
{
  /// <summary>
  /// Returns the recipients of the routing slip at the specified index.
  /// </summary>
  /// <param name="Index">Specifies the index.</param>
  /// <returns>The resulting value.</returns>
  public object Recipients(object Index);
}
