
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Microsoft Office Help Viewer assistance interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance?view=office-pia
/// </remarks>
public partial interface IAssistance
{
  /// <summary>
  /// Displays a Help topic in the Office Help Viewer.
  /// </summary>
  /// <param name="HelpId">The `HelpId` parameter.</param>
  /// <param name="Scope">The `Scope` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.showhelp?view=office-pia
  /// </remarks>
  public void ShowHelp(string HelpId, string Scope);
  /// <summary>
  /// Searches Help content in the Office Help Viewer.
  /// </summary>
  /// <param name="Query">The `Query` parameter.</param>
  /// <param name="Scope">The `Scope` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.searchhelp?view=office-pia
  /// </remarks>
  public void SearchHelp(string Query, string Scope);
  /// <summary>
  /// Sets the default Help context.
  /// </summary>
  /// <param name="HelpId">The `HelpId` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.setdefaultcontext?view=office-pia
  /// </remarks>
  public void SetDefaultContext(string HelpId);
  /// <summary>
  /// Clears a default Help context.
  /// </summary>
  /// <param name="HelpId">The `HelpId` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.cleardefaultcontext?view=office-pia
  /// </remarks>
  public void ClearDefaultContext(string HelpId);
}
