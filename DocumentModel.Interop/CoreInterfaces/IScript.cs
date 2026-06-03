using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a block of HTML script in an Office document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script?view=office-pia"/>
public interface IScript: IInteropObject
{
  /// <summary>
  /// Gets or sets additional attributes for the script tag.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.extended?view=office-pia"/>
  public string Extended { get; set; }
  /// <summary>
  /// Gets or sets the script ID.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.id?view=office-pia"/>
  public string Id { get; set; }
  /// <summary>
  /// Gets or sets the scripting language.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.language?view=office-pia"/>
  public ScriptLanguage Language { get; set; }
  /// <summary>
  /// Gets the script anchor location in the document.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.location?view=office-pia"/>
  public ScriptLocation Location { get; }
  /// <summary>
  /// Gets the shape associated with the script anchor.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.shape?view=office-pia"/>
  public object IShape { get; }
  /// <summary>
  /// Gets or sets the script content text.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.scripttext?view=office-pia"/>
  public string ScriptText { get; set; }


  #region methods

/// <summary>
  /// Deletes this script from the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.script.delete?view=office-pia"/>
  public void Delete();

  #endregion methods
}

