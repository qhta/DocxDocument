
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram?view=office-pia
/// </remarks>
public partial interface IMsoDiagram
{
  /// <summary>
  /// Converts the diagram to another diagram type.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.convert?view=office-pia
  /// </remarks>
  public void Convert(MsoDiagramType Type);
  /// <summary>
  /// Fits text within the diagram.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.fittext?view=office-pia
  /// </remarks>
  public void FitText();
}
