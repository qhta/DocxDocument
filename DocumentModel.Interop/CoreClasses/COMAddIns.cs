using System.Collections;
using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of COM add-ins registered in the Windows registry.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins?view=office-pia"/>
public partial class COMAddIns: InteropCollection<COMAddIn>
{


  #region methods

/// <summary>
  /// Returns a COM add-in from the collection by name or index.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins.item?view=office-pia"/>
  public COMAddIn Item(ref object index) { throw new NotImplementedException(); }
  /// <summary>
  /// Updates the COM add-ins collection.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins.update?view=office-pia"/>
  public void Update() { throw new NotImplementedException(); }
  /// <summary>
  /// Sets application modal state for COM add-ins UI interactions.
  /// </summary>
  /// <param name="varfModal">The `varfModal` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins.setappmodal?view=office-pia"/>
  public void SetAppModal(bool varfModal) { throw new NotImplementedException(); }

  #endregion methods
}

