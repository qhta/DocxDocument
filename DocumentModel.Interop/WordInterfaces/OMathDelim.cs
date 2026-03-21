namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a delimiter object, consisting of opening and closing delimiters (such as parentheses, braces, brackets, or vertical bars), and one or more elements contained inside the delimiters.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim?view=word-pia"/>
public interface OMathDelim : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.e?view=word-pia"/>
  public OMathArgs E { get; }
  /// <summary>
  /// The beg char.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.begchar?view=word-pia"/>
  public short BegChar { get; set; }
  /// <summary>
  /// The sep char.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.sepchar?view=word-pia"/>
  public short SepChar { get; set; }
  /// <summary>
  /// The end char.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.endchar?view=word-pia"/>
  public short EndChar { get; set; }
  /// <summary>
  /// The grow.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.grow?view=word-pia"/>
  public bool Grow { get; set; }
  /// <summary>
  /// The shape.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.shape?view=word-pia"/>
  public WdOMathShapeType Shape { get; set; }
  /// <summary>
  /// The no left char.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.noleftchar?view=word-pia"/>
  public bool NoLeftChar { get; set; }
  /// <summary>
  /// The no right char.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.omathdelim.norightchar?view=word-pia"/>
  public bool NoRightChar { get; set; }

}
