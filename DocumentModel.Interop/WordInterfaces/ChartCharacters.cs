namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents characters in an object that contains text.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters?view=word-pia"/>
public partial interface ChartCharacters : InteropObject
{
  /// <summary>
  /// The caption.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.caption?view=word-pia"/>
  public string Caption { get; set; }

  /// <summary>
  /// The count.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.count?view=word-pia"/>
  public int Count { get; }

  /// <summary>
  /// The font.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.font?view=word-pia"/>
  public ChartFont Font { get; }

  /// <summary>
  /// The text.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.text?view=word-pia"/>
  public string Text { get; set; }

  /// <summary>
  /// The phonetic characters.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.chartcharacters.phoneticcharacters?view=word-pia"/>
  public string PhoneticCharacters { get; set; }
}
