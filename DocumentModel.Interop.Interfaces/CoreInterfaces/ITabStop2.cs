
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TabStop2` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2?view=office-pia"/>
public interface ITabStop2: IInteropObject
{
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.position?view=office-pia"/>
  public float Position { get; set; }
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.type?view=office-pia"/>
  public TabStopType Type { get; set; }


  #region methods

/// <summary>
  /// Invokes `Clear`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.tabstop2.clear?view=office-pia"/>
  public void Clear();

  #endregion methods
}

