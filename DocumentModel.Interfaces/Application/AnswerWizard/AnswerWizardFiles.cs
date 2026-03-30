
namespace DocumentModel.Application;

/// <summary>
/// Contains all Answer Wizard files (.aw) available to the active Office application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles?view=office-pia"/>
public partial interface IAnswerWizardFiles: IModelObject
{
  /// <summary>
  /// Gets the file name at the specified index.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles.item?view=office-pia"/>
  public string this[int Index] { get; }
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles.count?view=office-pia"/>
  public int Count { get; }
}

