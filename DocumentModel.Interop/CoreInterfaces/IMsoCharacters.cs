
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
  /// Gets or sets the `Caption` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.caption?view=office-pia
  /// </remarks>
  public string Caption { get; set; }
  /// <summary>
  /// Gets the `Count` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.count?view=office-pia
  /// </remarks>
  public int Count { get; }
  /// <summary>
  /// Gets the `Font` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.font?view=office-pia
  /// </remarks>
  public ChartFont Font { get; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
  /// <summary>
  /// Gets or sets the `PhoneticCharacters` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters.phoneticcharacters?view=office-pia
  /// </remarks>
  public string PhoneticCharacters { get; set; }
}
