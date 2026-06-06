namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents the floor of a 3-D chart.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsofloor?view=office-pia"/>
public interface IFloor
{	

  #region methods	
/// <summary>
  /// Selects the chart floor.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsofloor.select?view=office-pia"/>
  public object Select();
  /// <summary>
  /// Clears formatting from the chart floor.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsofloor.clearformats?view=office-pia"/>
  public object ClearFormats();
  /// <summary>
  /// Pastes content onto the chart floor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsofloor.paste?view=office-pia"/>
  public void Paste();	
  #endregion methods
}	

