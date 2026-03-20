using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Script` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script?view=office-pia` for Office interop details.
/// </remarks>
public partial interface Script: InteropObject
{
  /// <summary>
  /// Gets or sets the `Extended` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.extended?view=office-pia
  /// </remarks>
  public string Extended { get; set; }
  /// <summary>
  /// Gets or sets the `Id` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.id?view=office-pia
  /// </remarks>
  public string Id { get; set; }
  /// <summary>
  /// Gets or sets the `Language` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.language?view=office-pia
  /// </remarks>
  public MsoScriptLanguage Language { get; set; }
  /// <summary>
  /// Gets the `Location` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.location?view=office-pia
  /// </remarks>
  public MsoScriptLocation Location { get; }
  /// <summary>
  /// Gets the `Shape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.shape?view=office-pia
  /// </remarks>
  public object Shape { get; }
  /// <summary>
  /// Gets or sets the `ScriptText` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.scripttext?view=office-pia
  /// </remarks>
  public string ScriptText { get; set; }
}
