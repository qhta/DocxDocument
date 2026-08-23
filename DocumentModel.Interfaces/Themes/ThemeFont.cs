namespace DocumentModel.Themes;

/// <summary>
/// Represents the `ThemeFont` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefont?view=office-pia"/>
public partial interface IThemeFont : IModelObject
{
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefont.name?view=office-pia"/>
  public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

