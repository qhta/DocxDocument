namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a delimiter object, consisting of opening and closing delimiters (such as parentheses, braces, brackets, or vertical bars), and one or more elements contained inside the delimiters.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim?view=word-pia"/>
public interface OMathDelim : InteropObject
{
  /// <summary>
  /// Returns the e.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.e?view=word-pia"/>
  public OMathArgs E { get; }
  /// <summary>
  /// Returns or sets the beg char.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.begchar?view=word-pia"/>
  public short BegChar { get; set; }
  /// <summary>
  /// Returns or sets the sep char.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.sepchar?view=word-pia"/>
  public short SepChar { get; set; }
  /// <summary>
  /// Returns or sets the end char.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.endchar?view=word-pia"/>
  public short EndChar { get; set; }
  /// <summary>
  /// Returns or sets whether grow.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.grow?view=word-pia"/>
  public bool Grow { get; set; }
  /// <summary>
  /// Returns or sets the shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.shape?view=word-pia"/>
  public WdOMathShapeType Shape { get; set; }
  /// <summary>
  /// Returns or sets whether no left char.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.noleftchar?view=word-pia"/>
  public bool NoLeftChar { get; set; }
  /// <summary>
  /// Returns or sets whether no right char.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.norightchar?view=word-pia"/>
  public bool NoRightChar { get; set; }

}
