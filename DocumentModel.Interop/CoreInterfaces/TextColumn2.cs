
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextColumn2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textcolumn2?view=office-pia"/>
public partial interface ITextColumn2: InteropObject
{
  /// <summary>
  /// Gets or sets the `Number` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textcolumn2.number?view=office-pia"/>
  public int Number { get; set; }
  /// <summary>
  /// Gets or sets the `Spacing` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textcolumn2.spacing?view=office-pia"/>
  public float Spacing { get; set; }
  /// <summary>
  /// Gets or sets the `TextDirection` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textcolumn2.textdirection?view=office-pia"/>
  public TextDirection TextDirection { get; set; }
}

