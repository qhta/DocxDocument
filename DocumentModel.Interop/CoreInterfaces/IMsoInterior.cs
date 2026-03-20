
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents interior formatting for a chart element.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior?view=office-pia
/// </remarks>
public partial interface IMsoInterior
{
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.color?view=office-pia
  /// </remarks>
  public object Color { get; set; }
  /// <summary>
  /// Gets or sets the `ColorIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.colorindex?view=office-pia
  /// </remarks>
  public object ColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `InvertIfNegative` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.invertifnegative?view=office-pia
  /// </remarks>
  public object InvertIfNegative { get; set; }
  /// <summary>
  /// Gets or sets the `Pattern` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.pattern?view=office-pia
  /// </remarks>
  public object Pattern { get; set; }
  /// <summary>
  /// Gets or sets the `PatternColor` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.patterncolor?view=office-pia
  /// </remarks>
  public object PatternColor { get; set; }
  /// <summary>
  /// Gets or sets the `PatternColorIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsointerior.patterncolorindex?view=office-pia
  /// </remarks>
  public object PatternColorIndex { get; set; }
}
