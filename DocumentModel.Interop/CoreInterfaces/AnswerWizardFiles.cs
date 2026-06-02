
namespace DocumentModel.Interop.Core;

/// <summary>
/// Contains all Answer Wizard files (.aw) available to the active Office application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles?view=office-pia"/>
public interface IAnswerWizardFiles: IInteropCollection<string>
{
}

