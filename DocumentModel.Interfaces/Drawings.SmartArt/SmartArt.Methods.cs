
namespace DocumentModel.Drawings.SmartArt;

/// <summary>
/// Represents the `SmartArt` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ISmartArt: IModelObject
{
  /// <summary>
  /// Invokes `Reset`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartart.reset?view=office-pia"/>
  public void Reset();
}

