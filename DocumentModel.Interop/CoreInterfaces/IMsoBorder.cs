
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents border formatting for a chart element.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder?view=office-pia
/// </remarks>
public partial interface IMsoBorder
{
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.color?view=office-pia
  /// </remarks>
  public object Color { get; set; }
  /// <summary>
  /// Gets or sets the `ColorIndex` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.colorindex?view=office-pia
  /// </remarks>
  public object ColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `LineStyle` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.linestyle?view=office-pia
  /// </remarks>
  public object LineStyle { get; set; }
  /// <summary>
  /// Gets or sets the `Weight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.weight?view=office-pia
  /// </remarks>
  public object Weight { get; set; }
}
