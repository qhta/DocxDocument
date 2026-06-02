
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the balloon where the Office Assistant displays information.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon?view=office-pia"/>
public partial interface IBalloon
{
  /// <summary>
  /// Sets a screen rectangle that the balloon should avoid covering.
  /// </summary>
  /// <param name="Left">The `Left` parameter.</param>
  /// <param name="Top">The `Top` parameter.</param>
  /// <param name="Right">The `Right` parameter.</param>
  /// <param name="Bottom">The `Bottom` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.setavoidrectangle?view=office-pia"/>
  public void SetAvoidRectangle(int Left, int Top, int Right, int Bottom);
  /// <summary>
  /// Displays the balloon and returns the button selected by the user.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.show?view=office-pia"/>
  public BalloonButtonType Show();
  /// <summary>
  /// Closes the balloon.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.close?view=office-pia"/>
  public void Close();
}

