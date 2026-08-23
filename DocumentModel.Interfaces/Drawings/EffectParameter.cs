namespace DocumentModel.Drawings;

/// <summary>
/// Describes a single picture effect parameter.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameter?view=office-pia"/>
public partial interface IEffectParameter : IModelObject
{
  /// <summary>
  /// Gets the parameter name.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameter.name?view=office-pia"/>
  public string Name { get; }
  /// <summary>
  /// Gets or sets the `Value` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.effectparameter.value?view=office-pia"/>
  public object Value { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

