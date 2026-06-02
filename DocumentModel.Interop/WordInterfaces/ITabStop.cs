namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single tab stop.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop?view=word-pia"/>
public interface ITabStop : IInteropObject
{
  /// <summary>
  /// Returns or sets a constant that represents the alignment for the specified tab stop.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.alignment?view=word-pia"/>
  public TabAlignment Alignment { get; set; }

  /// <summary>
  /// Returns or sets the leader for the specified TabStop object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.leader?view=word-pia"/>
  public TabLeader Leader { get; set; }

  /// <summary>
  /// Returns or sets the position of a tab stop relative to the left margin.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.position?view=word-pia"/>
  public float Position { get; set; }

  /// <summary>
  /// True if the specified tab stop is a custom tab stop.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.customtab?view=word-pia"/>
  public bool CustomTab { get; }

  /// <summary>
  /// Returns the next object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.next?view=word-pia"/>
  public TabStop Next { get; }

  /// <summary>
  /// Returns the previous object in the collection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.previous?view=word-pia"/>
  public TabStop Previous { get; }


  #region methods

/// <summary>
  /// Removes the specified custom tab stop.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.clear?view=word-pia"/>
  public void Clear();

  #endregion methods
}
