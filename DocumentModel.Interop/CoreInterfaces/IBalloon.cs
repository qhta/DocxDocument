
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the balloon where the Office Assistant displays information.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon?view=office-pia"/>
public interface IBalloon: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Checkboxes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.checkboxes?view=office-pia"/>
  public object Checkboxes { get; }
  /// <summary>
  /// Gets the `Labels` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.labels?view=office-pia"/>
  public object Labels { get; }
  /// <summary>
  /// Gets or sets the `BalloonType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.balloontype?view=office-pia"/>
  public BalloonType BalloonType { get; set; }
  /// <summary>
  /// Gets or sets the `Icon` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.icon?view=office-pia"/>
  public IconType Icon { get; set; }
  /// <summary>
  /// Gets or sets the `Heading` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.heading?view=office-pia"/>
  public string Heading { get; set; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `Mode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.mode?view=office-pia"/>
  public ModeType Mode { get; set; }
  /// <summary>
  /// Gets or sets the `Animation` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.animation?view=office-pia"/>
  public AnimationType Animation { get; set; }
  /// <summary>
  /// Gets or sets the `Button` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.button?view=office-pia"/>
  public ButtonSetType Button { get; set; }
  /// <summary>
  /// Gets or sets the `Callback` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.callback?view=office-pia"/>
  public string Callback { get; set; }
  /// <summary>
  /// Gets or sets the `Private` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.private?view=office-pia"/>
  public int Private { get; set; }
  /// <summary>
  /// Gets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.balloon.name?view=office-pia"/>
  public string Name { get; }


  #region methods

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

  #endregion methods
}

