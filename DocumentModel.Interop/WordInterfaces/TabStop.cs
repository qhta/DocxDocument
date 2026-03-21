namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single tab stop.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop?view=word-pia"/>
public partial interface TabStop : InteropObject
{
  /// <summary>
  /// Returns or sets the alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.alignment?view=word-pia"/>
  public WdTabAlignment Alignment { get; set; }

  /// <summary>
  /// Returns or sets the leader.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.leader?view=word-pia"/>
  public WdTabLeader Leader { get; set; }

  /// <summary>
  /// Returns or sets the position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.position?view=word-pia"/>
  public float Position { get; set; }

  /// <summary>
  /// Returns whether custom tab.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.customtab?view=word-pia"/>
  public bool CustomTab { get; }

  /// <summary>
  /// Returns the next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.next?view=word-pia"/>
  public TabStop Next { get; }

  /// <summary>
  /// Returns the previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.previous?view=word-pia"/>
  public TabStop Previous { get; }
}
