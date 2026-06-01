namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the PageMargins Class.
/// </summary>
public class PageMargins: ModelElement
{
  /// <summary>
  ///   l, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public Double? L { get; set; }

  /// <summary>
  ///   r, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public Double? R { get; set; }

  /// <summary>
  ///   t, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public Double? T { get; set; }

  /// <summary>
  ///   b, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public Double? B { get; set; }

  /// <summary>
  ///   header, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public Double? Header { get; set; }

  /// <summary>
  ///   footer, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public Double? Footer { get; set; }
}
