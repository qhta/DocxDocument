namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the FillToRectangle Class.
/// </summary>
public class FillToRectangle: ModelElement
{
  /// <summary>
  ///   l, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Left { get; set; }

  /// <summary>
  ///   t, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Top { get; set; }

  /// <summary>
  ///   r, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Right { get; set; }

  /// <summary>
  ///   b, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Bottom { get; set; }
}