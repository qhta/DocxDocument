namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a single tab stop.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop?view=word-pia"/>
public partial interface TabStop : InteropObject
{
  /// <summary>
  /// The alignment.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.alignment?view=word-pia"/>
  public WdTabAlignment Alignment { get; set; }

  /// <summary>
  /// The leader.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.leader?view=word-pia"/>
  public WdTabLeader Leader { get; set; }

  /// <summary>
  /// The position.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.position?view=word-pia"/>
  public float Position { get; set; }

  /// <summary>
  /// The custom tab.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.customtab?view=word-pia"/>
  public bool CustomTab { get; }

  /// <summary>
  /// The next.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.next?view=word-pia"/>
  public TabStop Next { get; }

  /// <summary>
  /// The previous.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.tabstop.previous?view=word-pia"/>
  public TabStop Previous { get; }
}
