using System.Reflection;

namespace DocumentModel.HTML;

/// <summary>
/// Represents a top-level HTML project branch in Script Editor.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject?view=office-pia"/>
public partial interface IHTMLProject: IModelObject
{
  /// <summary>
  /// Gets the `State` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.state?view=office-pia"/>
  public HTMLProjectState State { get; }
  /// <summary>
  /// Gets the `HTMLProjectItems` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.htmlproject.htmlprojectitems?view=office-pia"/>
  public IHTMLProjectItems HTMLProjectItems { get; }
}

