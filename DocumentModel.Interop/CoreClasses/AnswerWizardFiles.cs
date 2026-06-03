
namespace DocumentModel.Interop.Core;

/// <summary>
/// Contains all Answer Wizard files (.aw) available to the active Office application.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles?view=office-pia"/>
public partial class AnswerWizardFiles: InteropCollection<string>
{



  #region methods

/// <summary>
  /// Adds an Answer Wizard file to the collection.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles.add?view=office-pia"/>
  public void Add(string fileName) { throw new NotImplementedException(); }
  /// <summary>
  /// Removes an Answer Wizard file from the collection.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.answerwizardfiles.delete?view=office-pia"/>
  public void Delete(string fileName) { throw new NotImplementedException(); }

  #endregion methods
}

