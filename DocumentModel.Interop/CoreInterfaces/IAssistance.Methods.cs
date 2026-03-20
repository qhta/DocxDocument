
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IAssistance` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IAssistance
{
  /// <summary>
  /// Invokes `ShowHelp`.
  /// </summary>
  /// <param name="HelpId">The `HelpId` parameter.</param>
  /// <param name="Scope">The `Scope` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.showhelp?view=office-pia
  /// </remarks>
  public void ShowHelp(string HelpId, string Scope);
  /// <summary>
  /// Invokes `SearchHelp`.
  /// </summary>
  /// <param name="Query">The `Query` parameter.</param>
  /// <param name="Scope">The `Scope` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.searchhelp?view=office-pia
  /// </remarks>
  public void SearchHelp(string Query, string Scope);
  /// <summary>
  /// Invokes `SetDefaultContext`.
  /// </summary>
  /// <param name="HelpId">The `HelpId` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.setdefaultcontext?view=office-pia
  /// </remarks>
  public void SetDefaultContext(string HelpId);
  /// <summary>
  /// Invokes `ClearDefaultContext`.
  /// </summary>
  /// <param name="HelpId">The `HelpId` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.cleardefaultcontext?view=office-pia
  /// </remarks>
  public void ClearDefaultContext(string HelpId);
}
