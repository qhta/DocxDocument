namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single add-in, either installed or not installed.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin?view=word-pia"/>
public partial interface AddIn : InteropObject
{
  /// <summary>
  /// The name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.name?view=word-pia"/>
  public string Name { get; }

  /// <summary>
  /// The index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.index?view=word-pia"/>
  public int Index { get; }

  /// <summary>
  /// The path.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.path?view=word-pia"/>
  public string Path { get; }

  /// <summary>
  /// The installed.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.installed?view=word-pia"/>
  public bool Installed { get; set; }

  /// <summary>
  /// The compiled.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.compiled?view=word-pia"/>
  public bool Compiled { get; }

  /// <summary>
  /// The autoload.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.addin.autoload?view=word-pia"/>
  public bool Autoload { get; }
}
