namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single add-in, either installed or not installed.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin?view=word-pia"/>
public interface IAddIn : IInteropObject
{
  /// <summary>
  /// Gets the name of the add-in.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// Gets the index number of the add-in in the `AddIns` collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// Gets the path of the add-in.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// Gets or sets a value indicating whether the add-in is installed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.installed?view=word-pia"/>
  public bool Installed { get; set; }

  /// <summary>
  /// Gets a value indicating whether the add-in is compiled.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.compiled?view=word-pia"/>
  public bool Compiled { get; }

  /// <summary>
  /// Gets a value indicating whether the add-in is loaded automatically.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.autoload?view=word-pia"/>
  public bool Autoload { get; }
}
