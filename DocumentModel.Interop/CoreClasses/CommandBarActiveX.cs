namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `_CommandBarActiveX` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex?view=office-pia` for Office interop details.
/// </remarks>
public partial class CommandBarActiveX: CommandBarControl
{
   /// <summary>
  /// Gets or sets the `ControlCLSID` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.controlclsid?view=office-pia"/>
  public string? ControlCLSID { get; set; }
  /// <summary>
  /// Gets the `QueryControlInterface` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.querycontrolinterface?view=office-pia"/>
  public object? QueryControlInterface { get; set;}
  /// <summary>
  /// Gets or sets the `InitWith` property.
  /// </summary>
  public object? InitWith { get; set; }
  /// <summary>
  /// Gets the `InstanceIdPtr` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.instanceidptr?view=office-pia"/>
  public object? InstanceIdPtr { get; set;}


  #region methods

  /// <summary>
  /// Invokes `SetInnerObjectFactory`.
  /// </summary>
  /// <param name="pUnk">The `pUnk` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.setinnerobjectfactory?view=office-pia"/>
  public void SetInnerObjectFactory(object pUnk) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `EnsureControl`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._commandbaractivex.ensurecontrol?view=office-pia"/>
  public void EnsureControl() { throw new NotImplementedException(); }

  #endregion methods
}

