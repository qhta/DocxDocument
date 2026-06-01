using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single file search criterion.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest?view=office-pia"/>
public partial class PropertyTest: InteropObject
{
  /// <summary>
  /// Gets the name of the search property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets the condition used for the search criterion.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.condition?view=office-pia"/>
  public Condition Condition { get; }
  /// <summary>
  /// Gets the primary value used by the condition.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.value?view=office-pia"/>
  public object Value { get; }
  /// <summary>
  /// Gets the secondary value used by the condition.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.secondvalue?view=office-pia"/>
  public object SecondValue { get; }
  /// <summary>
  /// Gets the logical connector used with the next criterion.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.propertytest.connector?view=office-pia"/>
  public Connector Connector { get; }
}

