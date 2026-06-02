
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents characters in chart text.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters?view=office-pia"/>
public interface IMsoCharacters
{
  /// <summary>
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.caption?view=office-pia"/>
  public string Caption { get; set; }
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.count?view=office-pia"/>
  public int Count { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.font?view=office-pia"/>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `PhoneticCharacters` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.phoneticcharacters?view=office-pia"/>
  public string PhoneticCharacters { get; set; }


  #region methods

/// <summary>
  /// Deletes the specified characters.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.delete?view=office-pia"/>
  public object Delete();
  /// <summary>
  /// Inserts text at the specified character position.
  /// </summary>
  /// <param name="bstr">The `bstr` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.insert?view=office-pia"/>
  public object Insert(string bstr);

  #endregion methods
}

