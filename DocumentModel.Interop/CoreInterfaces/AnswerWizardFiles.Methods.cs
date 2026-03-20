
namespace DocumentModel.Interop.Core;

/// <summary>
/// Contains all Answer Wizard files (.aw) available to the active Office application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles?view=office-pia
/// </remarks>
public partial interface AnswerWizardFiles
{
  /// <summary>
  /// Adds an Answer Wizard file to the collection.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles.add?view=office-pia
  /// </remarks>
  public void Add(string FileName);
  /// <summary>
  /// Removes an Answer Wizard file from the collection.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles.delete?view=office-pia
  /// </remarks>
  public void Delete(string FileName);
}
