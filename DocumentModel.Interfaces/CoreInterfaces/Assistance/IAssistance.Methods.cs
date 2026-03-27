
namespace DocumentModel.Application;

/// <summary>
/// Represents the Microsoft Office Help Viewer assistance interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance?view=office-pia"/>
public partial interface IAssistance: InteropObject
{
  /// <summary>
  /// Displays a Help topic in the Office Help Viewer.
  /// </summary>
  /// <param name="HelpId">The `HelpId` parameter.</param>
  /// <param name="Scope">The `Scope` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.showhelp?view=office-pia"/>
  public void ShowHelp(string HelpId, string Scope);
  /// <summary>
  /// Searches Help content in the Office Help Viewer.
  /// </summary>
  /// <param name="Query">The `Query` parameter.</param>
  /// <param name="Scope">The `Scope` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.searchhelp?view=office-pia"/>
  public void SearchHelp(string Query, string Scope);
  /// <summary>
  /// Sets the default Help context.
  /// </summary>
  /// <param name="HelpId">The `HelpId` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.setdefaultcontext?view=office-pia"/>
  public void SetDefaultContext(string HelpId);
  /// <summary>
  /// Clears a default Help context.
  /// </summary>
  /// <param name="HelpId">The `HelpId` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.cleardefaultcontext?view=office-pia"/>
  public void ClearDefaultContext(string HelpId);
}

