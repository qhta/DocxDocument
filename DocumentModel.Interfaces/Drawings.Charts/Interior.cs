
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents interior formatting for a chart element.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior?view=office-pia"/>
public partial interface Interior: IModelObject
{
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.color?view=office-pia"/>
  public object Color { get; set; }
  /// <summary>
  /// Gets or sets the `ColorIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.colorindex?view=office-pia"/>
  public object ColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `InvertIfNegative` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.invertifnegative?view=office-pia"/>
  public object InvertIfNegative { get; set; }
  /// <summary>
  /// Gets or sets the `Pattern` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.pattern?view=office-pia"/>
  public object Pattern { get; set; }
  /// <summary>
  /// Gets or sets the `PatternColor` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.patterncolor?view=office-pia"/>
  public object PatternColor { get; set; }
  /// <summary>
  /// Gets or sets the `PatternColorIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.patterncolorindex?view=office-pia"/>
  public object PatternColorIndex { get; set; }
}

