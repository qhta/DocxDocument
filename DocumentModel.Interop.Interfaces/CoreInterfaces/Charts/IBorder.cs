
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents border formatting for a chart element.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder?view=office-pia"/>
public interface IBorder
{
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.color?view=office-pia"/>
  public object Color { get; set; }
  /// <summary>
  /// Gets or sets the `ColorIndex` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.colorindex?view=office-pia"/>
  public object ColorIndex { get; set; }
  /// <summary>
  /// Gets or sets the `LineStyle` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.linestyle?view=office-pia"/>
  public object LineStyle { get; set; }
  /// <summary>
  /// Gets or sets the `Weight` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.weight?view=office-pia"/>
  public object Weight { get; set; }
}


