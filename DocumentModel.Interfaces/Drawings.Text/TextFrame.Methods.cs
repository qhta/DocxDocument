
namespace DocumentModel.Drawings.Text;

/// <summary>
/// Represents the `TextFrame2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2?view=office-pia"/>
public partial interface TextFrame: IModelObject
{
  /// <summary>
  /// Invokes `DeleteText`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe2.deletetext?view=office-pia"/>
  public void DeleteText();
}

