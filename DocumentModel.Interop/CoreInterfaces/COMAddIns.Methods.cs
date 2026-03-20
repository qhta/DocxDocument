using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of COM add-ins registered in the Windows registry.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins?view=office-pia
/// </remarks>
public partial interface COMAddIns
{
  /// <summary>
  /// Returns a COM add-in from the collection by name or index.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins.item?view=office-pia
  /// </remarks>
  public COMAddIn Item(ref object Index);
  /// <summary>
  /// Updates the COM add-ins collection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins.update?view=office-pia
  /// </remarks>
  public void Update();
  /// <summary>
  /// Sets application modal state for COM add-ins UI interactions.
  /// </summary>
  /// <param name="varfModal">The `varfModal` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins.setappmodal?view=office-pia
  /// </remarks>
  public void SetAppModal(bool varfModal);
}
