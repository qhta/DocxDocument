
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents characters in chart text.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsocharacters?view=office-pia"/>
public partial interface ICharacters: IModelObject
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
  public IChartFont Font { get; }
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
}

