
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents characters in chart text.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters?view=office-pia"/>
public partial class MsoCharacters
{
  /// <summary>
  /// Deletes the specified characters.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.delete?view=office-pia"/>
  public object Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Inserts text at the specified character position.
  /// </summary>
  /// <param name="bstr">The `bstr` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.insert?view=office-pia"/>
  public object Insert(string bstr) { throw new NotImplementedException(); }
}


