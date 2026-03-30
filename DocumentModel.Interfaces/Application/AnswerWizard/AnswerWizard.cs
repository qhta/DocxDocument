
namespace DocumentModel.Application;

/// <summary>
/// Represents the Answer Wizard in a Microsoft Office application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard?view=office-pia"/>
public partial interface AnswerWizard: _IMsoDispObj, IModelObject
{
  /// <summary>
  /// Gets the Answer Wizard files available to the active Office application.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizard.files?view=office-pia"/>
  public AnswerWizardFiles Files { get; }
}

