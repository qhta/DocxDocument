
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the Answer Wizard in a Microsoft Office application.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard?view=office-pia"/>
public partial class AnswerWizard: InteropObject
{
  /// <summary>
  /// Gets the Answer Wizard files available to the active Office application.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.files?view=office-pia"/>
  public AnswerWizardFiles Files { get; }
}

