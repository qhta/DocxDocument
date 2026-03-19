namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents a delimiter object, consisting of opening and closing delimiters (such as parentheses, braces, brackets, or vertical bars), and one or more elements contained inside the delimiters.
/// </summary>
public interface OMathDelim : InteropObject
{
  /// <summary>
  /// The e.
  /// </summary>
  public OMathArgs E { get; }
  /// <summary>
  /// The beg char.
  /// </summary>
  public short BegChar { get; set; }
  /// <summary>
  /// The sep char.
  /// </summary>
  public short SepChar { get; set; }
  /// <summary>
  /// The end char.
  /// </summary>
  public short EndChar { get; set; }
  /// <summary>
  /// The grow.
  /// </summary>
  public bool Grow { get; set; }
  /// <summary>
  /// The shape.
  /// </summary>
  public WdOMathShapeType Shape { get; set; }
  /// <summary>
  /// The no left char.
  /// </summary>
  public bool NoLeftChar { get; set; }
  /// <summary>
  /// The no right char.
  /// </summary>
  public bool NoRightChar { get; set; }

}
