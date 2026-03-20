using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a block of HTML script in an Office document.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script?view=office-pia
/// </remarks>
public partial interface Script: InteropObject
{
  /// <summary>
  /// Gets or sets additional attributes for the script tag.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.extended?view=office-pia
  /// </remarks>
  public string Extended { get; set; }
  /// <summary>
  /// Gets or sets the script ID.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.id?view=office-pia
  /// </remarks>
  public string Id { get; set; }
  /// <summary>
  /// Gets or sets the scripting language.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.language?view=office-pia
  /// </remarks>
  public MsoScriptLanguage Language { get; set; }
  /// <summary>
  /// Gets the script anchor location in the document.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.location?view=office-pia
  /// </remarks>
  public MsoScriptLocation Location { get; }
  /// <summary>
  /// Gets the shape associated with the script anchor.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.shape?view=office-pia
  /// </remarks>
  public object Shape { get; }
  /// <summary>
  /// Gets or sets the script content text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.scripttext?view=office-pia
  /// </remarks>
  public string ScriptText { get; set; }
}
