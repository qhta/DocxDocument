
namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Represents border formatting for a chart element.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder?view=office-pia"/>
public partial interface IBorder: IModelObject
{
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.color?view=office-pia"/>
  public object Color { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `ColorIndex` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.colorindex?view=office-pia"/>
  public object ColorIndex { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `LineStyle` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.linestyle?view=office-pia"/>
  public object LineStyle { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Weight` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsoborder.weight?view=office-pia"/>
  public object Weight { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

