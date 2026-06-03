
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarButton` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton?view=office-pia` for Office interop details.
/// </remarks>
public interface ICommandBarButton: ICommandBarControl
{
  /// <summary>
  /// Gets or sets the `BuiltInFace` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.builtinface?view=office-pia"/>
  public bool BuiltInFace { get; set; }
  /// <summary>
  /// Gets or sets the `FaceId` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.faceid?view=office-pia"/>
  public int FaceId { get; set; }
  /// <summary>
  /// Gets or sets the `ShortcutText` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.shortcuttext?view=office-pia"/>
  public string ShortcutText { get; set; }
  /// <summary>
  /// Gets or sets the `State` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.state?view=office-pia"/>
  public new ButtonState State { get; set; }
  /// <summary>
  /// Gets or sets the `Style` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.style?view=office-pia"/>
  public ButtonStyle Style { get; set; }
  /// <summary>
  /// Gets or sets the `HyperlinkType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.hyperlinktype?view=office-pia"/>
  public CommandBarButtonHyperlinkType HyperlinkType { get; set; }
  /// <summary>
  /// Gets or sets the `Picture` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.picture?view=office-pia"/>
  public object Picture { get; set; }
  /// <summary>
  /// Gets or sets the `Mask` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.mask?view=office-pia"/>
  public object Mask { get; set; }


  #region methods

  /// <summary>
  /// Invokes `CopyFace`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.copyface?view=office-pia"/>
  public void CopyFace();

  /// <summary>
  /// Invokes `PasteFace`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbutton.pasteface?view=office-pia"/>
  public void PasteFace();

  #endregion methods
}

