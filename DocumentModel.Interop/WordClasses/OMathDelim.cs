namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a delimiter object, consisting of opening and closing delimiters (such as parentheses, braces, brackets, or vertical bars), and one or more elements contained inside the delimiters.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim?view=word-pia"/>
public class OMathDelim : InteropObject
{
  /// <summary>
  /// Returns the collection of expressions inside the delimiters.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.e?view=word-pia"/>
  public OMathArgs E { get; }
  /// <summary>
  /// Returns or sets the opening delimiter character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.begchar?view=word-pia"/>
  public short BegChar { get; set; }
  /// <summary>
  /// Returns or sets the separator character between arguments.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.sepchar?view=word-pia"/>
  public short SepChar { get; set; }
  /// <summary>
  /// Returns or sets the closing delimiter character.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.endchar?view=word-pia"/>
  public short EndChar { get; set; }
  /// <summary>
  /// Returns or sets whether delimiters grow to fit the enclosed expressions.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.grow?view=word-pia"/>
  public bool Grow { get; set; }
  /// <summary>
  /// Returns or sets the shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.shape?view=word-pia"/>
  public OMathShapeType Shape { get; set; }
  /// <summary>
  /// Returns or sets whether the left delimiter is omitted.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.noleftchar?view=word-pia"/>
  public bool NoLeftChar { get; set; }
  /// <summary>
  /// Returns or sets whether the right delimiter is omitted.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.norightchar?view=word-pia"/>
  public bool NoRightChar { get; set; }

}
