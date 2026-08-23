
namespace DocumentModel.Drawings.Text;

/// <summary>
/// Represents the `TabStop2` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2?view=office-pia"/>
public partial interface ITabStop : IModelObject
{
  /// <summary>
  /// Invokes `Clear`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.clear?view=office-pia"/>
  public void Clear();
}

