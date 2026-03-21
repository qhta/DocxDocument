
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents shadow formatting for a shape.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat?view=office-pia"/>
public partial interface ShadowFormat
{
  /// <summary>
  /// Changes the horizontal shadow offset by the specified amount.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.incrementoffsetx?view=office-pia"/>
  public void IncrementOffsetX(float Increment);
  /// <summary>
  /// Changes the vertical shadow offset by the specified amount.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.shadowformat.incrementoffsety?view=office-pia"/>
  public void IncrementOffsetY(float Increment);
}

