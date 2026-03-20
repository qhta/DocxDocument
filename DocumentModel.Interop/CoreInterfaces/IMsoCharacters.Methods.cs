
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoCharacters` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoCharacters
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Invokes `Insert`.
  /// </summary>
  /// <param name="bstr">The `bstr` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.insert?view=office-pia
  /// </remarks>
  public object Insert(string bstr);
}
