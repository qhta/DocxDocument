
namespace DocumentModel.Interop.Core;

/// <summary>
/// Contains all Answer Wizard files (.aw) available to the active Office application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles?view=office-pia
/// </remarks>
public partial interface AnswerWizardFiles: InteropObject
{
  /// <summary>
  /// Gets the file name at the specified index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles.item?view=office-pia
  /// </remarks>
  public string this[int Index] { get; }
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles.count?view=office-pia
  /// </remarks>
  public int Count { get; }
}
