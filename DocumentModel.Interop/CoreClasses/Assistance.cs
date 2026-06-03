
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Microsoft Office Help Viewer assistance class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance?view=office-pia"/>
public partial class Assistance
{


  #region methods

/// <summary>
  /// Displays a Help topic in the Office Help Viewer.
  /// </summary>
  /// <param name="helpId">The `HelpId` parameter.</param>
  /// <param name="scope">The `Scope` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.showhelp?view=office-pia"/>
  public void ShowHelp(string helpId, string scope) { throw new NotImplementedException(); }
  /// <summary>
  /// Searches Help content in the Office Help Viewer.
  /// </summary>
  /// <param name="query">The `Query` parameter.</param>
  /// <param name="scope">The `Scope` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.searchhelp?view=office-pia"/>
  public void SearchHelp(string query, string scope) { throw new NotImplementedException(); }
  /// <summary>
  /// Sets the default Help context.
  /// </summary>
  /// <param name="helpId">The `HelpId` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.setdefaultcontext?view=office-pia"/>
  public void SetDefaultContext(string helpId) { throw new NotImplementedException(); }
  /// <summary>
  /// Clears a default Help context.
  /// </summary>
  /// <param name="helpId">The `HelpId` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iassistance.cleardefaultcontext?view=office-pia"/>
  public void ClearDefaultContext(string helpId) { throw new NotImplementedException(); }

  #endregion methods
}

