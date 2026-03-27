
namespace DocumentModel.Application;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram?view=office-pia"/>
public partial interface Diagram
{
  /// <summary>
  /// Converts the diagram to another diagram type.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.convert?view=office-pia"/>
  public void Convert(DiagramType Type);
  /// <summary>
  /// Fits text within the diagram.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.fittext?view=office-pia"/>
  public void FitText();
}

