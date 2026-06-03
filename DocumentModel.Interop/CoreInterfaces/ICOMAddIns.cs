namespace DocumentModel.Interop.Core;

/// <summary>
/// A collection of COM add-ins registered in the Windows registry.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins?view=office-pia"/>
public interface ICOMAddIns: IInteropCollection<ICOMAddIn>
{


  #region methods

/// <summary>
  /// Returns a COM add-in from the collection by name or index.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins.item?view=office-pia"/>
  public ICOMAddIn Item(ref object index);
  /// <summary>
  /// Updates the COM add-ins collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins.update?view=office-pia"/>
  public void Update();
  /// <summary>
  /// Sets application modal state for COM add-ins UI interactions.
  /// </summary>
  /// <param name="varfModal">The `varfModal` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.comaddins.setappmodal?view=office-pia"/>
  public void SetAppModal(bool varfModal);

  #endregion methods
}

