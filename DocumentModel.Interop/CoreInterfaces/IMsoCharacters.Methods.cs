
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents characters in chart text.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters?view=office-pia
/// </remarks>
public partial interface IMsoCharacters
{
  /// <summary>
  /// Deletes the specified characters.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.delete?view=office-pia
  /// </remarks>
  public object Delete();
  /// <summary>
  /// Inserts text at the specified character position.
  /// </summary>
  /// <param name="bstr">The `bstr` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.insert?view=office-pia
  /// </remarks>
  public object Insert(string bstr);
}
