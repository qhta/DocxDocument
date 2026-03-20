
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Answer Wizard in a Microsoft Office application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard?view=office-pia
/// </remarks>
public partial interface AnswerWizard: InteropObject
{
  /// <summary>
  /// Gets the Answer Wizard files available to the active Office application.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.files?view=office-pia
  /// </remarks>
  public AnswerWizardFiles Files { get; }
}
