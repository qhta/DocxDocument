namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the LineJoinMiterProperties Class.
/// </summary>
public class LineJoinMiterProperties: ModelElement
{
  /// <summary>
  ///   lim, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? Limit { get; set; }
}