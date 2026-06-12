
namespace DocumentModel.Drawings.Text;

/// <summary>
/// Contains first-line and hanging indent settings for an outline level.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevel2?view=office-pia"/>
public partial interface IRulerLevel: IModelObject
{
  /// <summary>
  /// Gets or sets the first-line indent.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevel2.firstmargin?view=office-pia"/>
  public float FirstMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the left (hanging) indent.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.rulerlevel2.leftmargin?view=office-pia"/>
  public float LeftMargin { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

