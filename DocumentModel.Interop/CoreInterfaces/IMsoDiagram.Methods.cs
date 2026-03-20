
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `IMsoDiagram` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IMsoDiagram
{
  /// <summary>
  /// Invokes `Convert`.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.convert?view=office-pia
  /// </remarks>
  public void Convert(MsoDiagramType Type);
  /// <summary>
  /// Invokes `FitText`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.fittext?view=office-pia
  /// </remarks>
  public void FitText();
}
