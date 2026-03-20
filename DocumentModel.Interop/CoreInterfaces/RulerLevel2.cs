
namespace DocumentModel.Interop.Core;

/// <summary>
/// Contains first-line and hanging indent settings for an outline level.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevel2?view=office-pia
/// </remarks>
public partial interface RulerLevel2: InteropObject
{
  /// <summary>
  /// Gets or sets the first-line indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevel2.firstmargin?view=office-pia
  /// </remarks>
  public float FirstMargin { get; set; }
  /// <summary>
  /// Gets or sets the left (hanging) indent.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevel2.leftmargin?view=office-pia
  /// </remarks>
  public float LeftMargin { get; set; }
}
