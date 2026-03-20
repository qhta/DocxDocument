
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the balloon where the Office Assistant displays information.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon?view=office-pia
/// </remarks>
public partial interface Balloon
{
  /// <summary>
  /// Sets a screen rectangle that the balloon should avoid covering.
  /// </summary>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Right">The `Right` parameter.</param>
  /// <param name="Bottom">The `Bottom` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.setavoidrectangle?view=office-pia
  /// </remarks>
  public void SetAvoidRectangle(int Left, int Top, int Right, int Bottom);
  /// <summary>
  /// Displays the balloon and returns the button selected by the user.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.show?view=office-pia
  /// </remarks>
  public MsoBalloonButtonType Show();
  /// <summary>
  /// Closes the balloon.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.close?view=office-pia
  /// </remarks>
  public void Close();
}
