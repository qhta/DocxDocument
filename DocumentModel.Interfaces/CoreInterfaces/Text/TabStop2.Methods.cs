
namespace DocumentModel.Application;

/// <summary>
/// Represents the `TabStop2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2?view=office-pia"/>
public partial interface TabStop2: InteropObject
{
  /// <summary>
  /// Invokes `Clear`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.clear?view=office-pia"/>
  public void Clear();
}

