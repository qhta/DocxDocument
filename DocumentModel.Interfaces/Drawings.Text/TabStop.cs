
namespace DocumentModel.Drawings.Text;

/// <summary>
/// Represents the `TabStop2` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2?view=office-pia"/>
public partial interface ITabStop: IModelObject
{
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.position?view=office-pia"/>
  public float Position { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.type?view=office-pia"/>
  public TabStopType Type { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

