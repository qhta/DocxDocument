
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarButtonEvents` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents?view=office-pia` for Office interop details.
/// </remarks>
public partial class _CommandBarButtonEvents
{


  #region methods

/// <summary>
  /// Invokes `Click`.
  /// </summary>
  /// <param name="Ctrl">The `Ctrl` parameter.</param>
  /// <param name="CancelDefault">The `CancelDefault` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbarbuttonevents.click?view=office-pia"/>
  public void Click(CommandBarButton Ctrl, ref bool CancelDefault) { throw new NotImplementedException(); }

  #endregion methods
}
