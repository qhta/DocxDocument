
namespace DocumentModel.Interop.Core;

/// <summary>
/// Reserved for internal use.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram?view=office-pia"/>
public partial class MsoDiagram
{
  /// <summary>
  /// Converts the diagram to another diagram type.
  /// </summary>
  /// <param name="Type">The `Type` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.convert?view=office-pia"/>
  public void Convert(DiagramType Type) { throw new NotImplementedException(); }
  /// <summary>
  /// Fits text within the diagram.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.imsodiagram.fittext?view=office-pia"/>
  public void FitText() { throw new NotImplementedException(); }
}


